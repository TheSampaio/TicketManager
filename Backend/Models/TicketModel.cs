using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class TicketModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int RequesterId { get; set; }

        public int? TechnicianId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? CompletedAt { get; set; }
    }
}
