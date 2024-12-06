using api.Models;

namespace api.DTOs.Inventory
{
    public class InventoryDTO
    {
        public int InvId { get; set; }
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public int Genera { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public int Studio { get; set; }
        public int Status { get; set; }
      //  public List<InvComments>? IComments { get; set; } = new List<InvComments>();
    }
}
