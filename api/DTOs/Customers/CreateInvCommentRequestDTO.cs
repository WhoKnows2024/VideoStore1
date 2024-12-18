using api.Models;

namespace api.DTOs.Customers
{
    public class CreateInvCommentRequestDTO
    {
        public int InvCommentId { get; set; }
        public int InvId { get; set; }
        public string? InvComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;

    }
}
