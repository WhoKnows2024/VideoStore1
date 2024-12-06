using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CustComment { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;
        public DateTime LastRental { get; set; } = DateTime.Now;
        public List<CustComments> CComment { get; set; } = new List<CustComments>();
    }
}
