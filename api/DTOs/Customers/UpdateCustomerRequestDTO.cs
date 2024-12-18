namespace api.DTOs.Customers
{
    public class UpdateCustomerRequestDTO
    {
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CustComment { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;
        public DateTime LastRental { get; set; } = DateTime.Now;
        //  public List<CustComments> CComment { get; set; } = new List<CustComments>();
    }
}
