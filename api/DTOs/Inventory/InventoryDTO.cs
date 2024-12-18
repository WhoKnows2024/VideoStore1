﻿using api.Models;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs.Inventory
{
    public class InventoryDTO
    {
        public int InvId { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Rating { get; set; }
        public int Genera { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public int Studio { get; set; }
        public int Status { get; set; }
      //  public List<InvComments>? IComments { get; set; } = new List<InvComments>();
    }
}
