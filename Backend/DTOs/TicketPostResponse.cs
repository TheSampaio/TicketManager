namespace Backend.DTOs
{
    public class TicketPostResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RequesterId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
