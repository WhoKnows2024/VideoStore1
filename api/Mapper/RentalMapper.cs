﻿using api.DTOs.Rental;
using api.Models;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace api.Mapper
{
    public static class RentalMapper
    {
        public static RentalDTO ToRentalDTO(this Rental rentalModel)
        {
            return new RentalDTO
            {
                 RentalId = rentalModel.RentalId,
                 Status = rentalModel.Status,
                 CheckOut = rentalModel.CheckOut,
                 CheckedIn = rentalModel.CheckedIn,
                 CustId = rentalModel.CustId,
                 InventoryID = rentalModel.InventoryID,
            };
        }
        public static Rental ToRentalFromCreateDTO(this CreateRentalRequestDTO rentalDTO)
        {
            return new Rental()
            {
                Status = rentalDTO.Status,
                Checkout = rentalDTO.CheckOut,
                CheckedIn = rentalDTO.CheckedIn,
                CustId = rentalDTO.CustId,
                InventoryID = rentalDTO.InventoryID
            };

        }
    }
}
