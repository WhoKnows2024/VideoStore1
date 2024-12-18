using api.Data;
using api.DTOs.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Mapper;
using api.DTOs.Inventory;

namespace api.Controllers
{
    [Route("api/invComment")]
    [ApiController]
    
    public class InvCommentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public object InvCommentDTO { get; private set; }

        public InvCommentController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllInvComments()
        {
            var invComments = _context.InvComments.ToList();
            return(Ok(invComments));
        }
        [HttpGet("id")]
        public IActionResult GetInvCommentId([FromRoute] int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(id);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateInvCommentRequestDTO invCommentDTO)
        {
            var invCommentModel = invCommentDTO.ToInvCommentFromCreateDTO();
            _context.InvComments.Add(invCommentModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetInvCommentId), new {id = invCommentModel.InvCommentId}, invCommentModel.ToInvCommentDTO());

        }
        [HttpPut]
        [Route("{invCommentId}")]
        public IActionResult Update([FromRoute] int invCommentId, [FromBody] UpdateInvCommentRequestDTO updateDTO)
        {
            var invCommentModel = _context.InvComments.FirstOrDefault( i => i.InvCommentId == invCommentId);
            if (invCommentModel == null)
            {
                return NotFound();
            }
            invCommentModel.InvCommentId = updateDTO.InvCommentId;
            invCommentModel.InvComment = updateDTO.InvComments;
            _context.SaveChanges();
            return Ok(invCommentModel.ToInvCommentDTO());

        }
    }
}