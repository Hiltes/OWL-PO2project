using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OWL.Models;

namespace OWL.Data
{
    public class OwlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Participation> Participations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connStr = configuration.GetConnectionString("OwlDatabase");

                optionsBuilder
                    .UseNpgsql(connStr)
                    .EnableSensitiveDataLogging()
                    .LogTo(Console.WriteLine, LogLevel.Information);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // -------------------
            // Konfiguracja dla User
            // -------------------
            modelBuilder.Entity<User>(builder =>
            {
                builder.HasKey(u => u.UserId);

                builder.Property(u => u.Username)
                       .HasMaxLength(50)
                       .IsRequired();

                builder.Property(u => u.Email)
                       .IsRequired();

                // Mapowanie na prywatne pole _organizedEvents
                builder.Metadata
                       .FindNavigation(nameof(User.OrganizedEvents))!
                       .SetPropertyAccessMode(PropertyAccessMode.Field);

                // Mapowanie na prywatne pole _participations
                builder.Metadata
                       .FindNavigation(nameof(User.Participations))!
                       .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            // -------------------
            // Konfiguracja dla Event
            // -------------------
            modelBuilder.Entity<Event>(builder =>
            {
                builder.HasKey(e => e.EventId);

                builder.Property(e => e.Title)
                       .HasMaxLength(100)
                       .IsRequired();

                builder.Property(e => e.Description)
                       .IsRequired();

                builder.Property(e => e.Date)
                       .IsRequired();

                builder.Property(e => e.Location)
                       .IsRequired();

                builder.HasOne(e => e.Organizer)
                       .WithMany(u => u.OrganizedEvents)
                       .HasForeignKey(e => e.OrganizerId)
                       .OnDelete(DeleteBehavior.Restrict);

                // Mapowanie na prywatne pole _participants
                builder.Metadata
                       .FindNavigation(nameof(Event.Participants))!
                       .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            // -------------------
            // Konfiguracja dla Participation
            // -------------------
            modelBuilder.Entity<Participation>(builder =>
            {
                // Używamy jednoznacznego klucza ParticipationId
                builder.HasKey(p => p.ParticipationId);

                builder.HasOne(p => p.User)
                       .WithMany(u => u.Participations)
                       .HasForeignKey(p => p.UserId);

                builder.HasOne(p => p.Event)
                       .WithMany(e => e.Participants)
                       .HasForeignKey(p => p.EventId);
            });
        }
    }
}
