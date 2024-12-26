namespace api.DTOs.Customers
{
    public class UpdateCustCommentRequestDTO
    {

        public int CustId { get; set; }
        public string? CustComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;
    }
}
