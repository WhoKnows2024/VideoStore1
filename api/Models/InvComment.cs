using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class InvComments
    {
        [Key]
        public int InvCommentId { get; set; }
        public  int InvId { get; set; }
        public required string InvComment { get; set; }
        public DateTime Entered { get; set; } = DateTime.Now;

    }

}