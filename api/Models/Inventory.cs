using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Inventory
    {
        [Key]
        public int InvId { get; set; }  
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public int Genera { get; set; } 
        public DateTime  ReleaseDate { get; set; }
        public int Length { get; set; } 
        public int Studio { get; set; }
        public int Status { get; set; }
        public List<InvComments>? IComments { get; set; } = new List<InvComments>();
    }
}