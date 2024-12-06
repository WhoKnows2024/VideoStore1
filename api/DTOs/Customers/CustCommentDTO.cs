namespace api.DTOs.Customers
{
    public class CustCommentDTO
    {
        public int CustCommentId { get; set; }
        public int CustId { get; set; }
        public string? CustComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;
    }
}
