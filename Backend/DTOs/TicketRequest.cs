using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class TicketRequest
    {
        [Required, MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int RequesterId { get; set; }
    }
}
