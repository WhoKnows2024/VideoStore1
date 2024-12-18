using api.Data;
using api.DTOs.Inventory;
using api.DTOs.Rental;
using api.Mapper;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/inventory")]
    [ApiController]

    public class InventoryController : ControllerBase
    {
        private ApplicationDBContext _context;
        public InventoryController(ApplicationDBContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAllInventory()
        {
            var inventory = _context.Inventory.ToList();
            return Ok(inventory);
        }
        //Get api/Inventory/{InvId}
        [HttpGet("{InvId}")]
        public IActionResult GetInventoryByid([FromRoute] int id)
        {
            var inventory = _context.Inventory.Find(id);
            if (inventory == null)
            {
                return NotFound();
            }
            return Ok(inventory);
        }
        //Get api/Inventory/{title}
        [HttpGet("{title}")]
        public IActionResult GetbyTitle([FromRoute] string title)
        {
            var title1 = _context.Inventory.Find(title);
            if (title == null)
            {
                return NotFound(title);
            }
            return Ok(title);
        }
        [HttpGet("{genera}")]

        public IActionResult GetByGenera([FromRoute] int genera)
        {
            var genera1 = _context.Inventory.Find(genera);
            if (genera1 == null)
            {
                return NotFound(genera1);
            }
            return Ok(genera1);

        }
        [HttpGet("{studio}")]
        public IActionResult GetByStudio([FromRoute] int studio)
        {
            var studioId = _context.Inventory.Find(studio);
            if (studio == null)
            {
                return NotFound(studioId);
            }
            return Ok(studioId);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateInventoryRequestDTO inventoryDTO)
        {
            var inventoryModel = inventoryDTO.ToInventoryFromCreateDTO();
                _context.Inventory.Add(inventoryModel);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetInventoryByid), new { id = inventoryModel.InvId }, inventoryModel.ToInventoryDTO());
        }
        [HttpPut]
        [Route("{InvId}")]
        public IActionResult Update([FromRoute] int invId, [FromBody] UpdateRentalRequestDTO updateRental)
        {
            var inventoryModel = _context.Inventory.FirstOrDefault(r => r.InvId == invId);  
            if(inventoryModel == null)
            {
                return NotFound(inventoryModel);
            }
            inventoryModel.Title = inventoryModel.Title;
            inventoryModel.Rating = inventoryModel.Rating;
            inventoryModel.Genera = inventoryModel.Genera;
            inventoryModel.ReleaseDate = inventoryModel.ReleaseDate;
            inventoryModel.Length = inventoryModel.Length;
            inventoryModel.Studio = inventoryModel.Studio;
            inventoryModel.Status = inventoryModel.Status;

            _context.SaveChanges();
            return Ok(inventoryModel.ToInventoryDTO());

        }
    }
}