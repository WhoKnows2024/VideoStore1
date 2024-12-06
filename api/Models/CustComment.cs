using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class CustComments
    {
        [Key]
        public int CustCommentId { get; set; }
        public int CustId { get; set; }
        public string? CustComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;

    }
}