using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Rentals
    {
        [Key]

        public int RentalId { get; set; }
        public int Status   { get; set; }
        public DateTime? CheckOut { get; set; } = DateTime.Now;
        public DateTime? CheckedIn { get; set; } = DateTime.Now;
        public int CustId { get; set; }
        public int InventoryID { get; set; }

    }
}