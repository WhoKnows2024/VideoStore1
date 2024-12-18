namespace api.DTOs.Customers
{
    public class UpdateCustCommentRequestDTO
    {
        public int InvId { get; set; }
        public required string InvComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;
    }
}
