using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OWL.Models
{
    public class Participation
    {
        [Key]
        public int ParticipationId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }
        public int EventId { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }
    }
}
