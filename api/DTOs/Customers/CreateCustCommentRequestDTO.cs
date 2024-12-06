namespace api.DTOs.Customers
{
    public class CreateCustCommentRequestDTO
    {
        public int CustId { get; set; }
        public string? CustComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;
    }
}
