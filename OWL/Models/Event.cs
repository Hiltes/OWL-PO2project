using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OWL.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Title { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Date { get; set; }  

        [Required]
        public string? Location { get; set; }

        [ForeignKey("OrganizerId")]
        public User Organizer { get; set; }
        public int OrganizerId { get; set; }

        public ICollection<Participation>? Participants { get; set; }
    }
}