using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OWL.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public required string PasswordHash { get; set; }

        public ICollection<Event> OrganizedEvents { get; set; } = new List<Event>();
        public ICollection<Participation> Participations { get; set; } = new List<Participation>();
    }
}