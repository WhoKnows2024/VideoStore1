namespace api.DTOs.Inventory
{
    public class UpdateInvCommentRequestDTO
    {
        public int InvCommentId { get; set; }
        public int InvId { get; set; }
        public required string InvComments { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;
    }
}
