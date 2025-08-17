using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class TicketRequest
    {
        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required, MaxLength(50)]
        public string RequesterId { get; set; } = string.Empty;
    }
}
