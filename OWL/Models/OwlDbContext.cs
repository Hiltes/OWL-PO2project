using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OWL.Models;

namespace OWL.Models
{
    public class OwlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Participation> Participations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName)
                .AddJsonFile("appsettings.json")
                .Build();

                optionsBuilder.UseNpgsql(configuration.GetConnectionString("OwlDatabase"))
                   .EnableSensitiveDataLogging()
                   .LogTo(Console.WriteLine, LogLevel.Information);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(u => u.OrganizedEvents)
                .HasForeignKey(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Participation>()
                .HasKey(p => new { p.UserId, p.EventId });

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.User)
                .WithMany(u => u.Participations)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Event)
                .WithMany(e => e.Participants)
                .HasForeignKey(p => p.EventId);
        }
    }
}