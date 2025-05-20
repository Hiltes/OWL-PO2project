using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
                var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName)
    .AddJsonFile("appsettings.json")
    .Build();

                optionsBuilder.UseNpgsql(configuration.GetConnectionString("OwlDatabase"));
            }
        }
    }
}