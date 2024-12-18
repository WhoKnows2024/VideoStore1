using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs.Inventory;
using api.DTOs.Rental;
using api.Mapper;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [Route("api/Rental")]
    [ApiController]

    public class RentalController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public RentalController(ApplicationDBContext context)
        {   //constructor
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Rentals = _context.Rentals.ToList();
            return Ok(Rentals);
        }

        [HttpGet("{RentalId}")]
        public IActionResult GetRentalById([FromRoute] int id)
        {
            var rentals = _context.Rentals.Find(id);

            if (rentals == null)
            {
                return NotFound();
            }
            return Ok(rentals);
        }

        [HttpGet("{CustId}")]
        public IActionResult GetRentalByCustIf([FromRoute] int id)
        {
            var rentCustId = _context.Rentals.Find(id);
            if (rentCustId == null)
            {
                return NotFound();

            }
            return Ok(rentCustId);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateRentalRequestDTO rentalDTO)
        {
          
            var rentalModel = rentalDTO.ToRentalFromCreateDTO();
            _context.Rentals.Add(rentalModel);    
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetRentalById), new { id = rentalModel.RentalId }, rentalModel.ToRentalDTO);
        }
        [HttpPut]
        [Route("{RentalId}")]
        public IActionResult Update([FromRoute]int rentalId, [FromBody] UpdateRentalRequestDTO updateDTO)
        {
            var rentalModel = _context.Rentals.FirstOrDefault(r => r.RentalId == rentalId);
            if(rentalModel == null)
            {
                return NotFound();
            }
            rentalModel.Status = updateDTO.Status;
            rentalModel.CheckedIn = updateDTO.CheckedIn;
            rentalModel.CheckOut = updateDTO.CheckOut;
            rentalModel.CustId = updateDTO.CustId;
            rentalModel.InventoryID = updateDTO.InventoryID;

            _context.SaveChanges();
            return Ok(rentalModel.ToRentalDTO);
        }
    }
}
