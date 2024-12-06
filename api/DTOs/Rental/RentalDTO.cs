namespace api.DTOs.Rentals
{
    public class RentalDTO
    {
        public int RentalId { get; set; }
        public int Status { get; set; }
        public DateTime? CheckOut { get; set; } = DateTime.Now;
        public DateTime? CheckedIn { get; set; } = DateTime.Now;
        public int CustId { get; set; }
        public int InventoryID { get; set; }
    }
}
