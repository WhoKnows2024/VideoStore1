﻿using api.DTOs.Inventory;
using api.Models;

namespace api.Mapper
{
    public static class InventoryMapper
    {
        public static InventoryDTO ToInventoryDTO(this Inventory inventoryModel)
        {
            return new InventoryDTO
            {
                InvId = inventoryModel.InvId,
                Title = inventoryModel.Title,
                Rating = inventoryModel.Rating,
                Genera = inventoryModel.Genera,
                ReleaseDate = inventoryModel.ReleaseDate,
                Length = inventoryModel.Length,
                Studio = inventoryModel.Studio,
                Status = inventoryModel.Status
            };
        }
        public static Inventory ToInventoryFromCreateDTO(this CreateInventoryRequestDTO inventoryDTO)
        {
            return new Inventory
            {
                Title = inventoryDTO.Title,
                Rating = inventoryDTO.Rating,
                Genera = inventoryDTO.Genera,
                ReleaseDate = inventoryDTO.ReleaseDate,
                Length = inventoryDTO.Length,
                Studio = inventoryDTO.Studio,
                Status = inventoryDTO.Status
            };
        }
    }
}
