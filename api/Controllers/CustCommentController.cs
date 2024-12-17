using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs.Customers;
using api.Mapper;
using api.Models;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    
    [Route("api/CustComments")]
    [ApiController]

    public class CustCommentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CustCommentController(ApplicationDBContext context)
        {   //constructor
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var CustComments = _context.CustComments.ToList();
            return Ok(CustComments);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustCommentById([FromRoute] int id)
        {
            var custComments = _context.CustComments.Find(id);

            if (custComments == null)
            {
                 return NotFound();
            }
            return Ok(custComments);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCustCommentRequestDTO custCommentDTO)
        {
            var custCommentModel = custCommentDTO.ToCustCommentFromCreateDTO();
            _context.CustComments.Add(custCommentModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCustCommentById), new { id = custCommentModel.CustId}, custCommentModel.ToCustCommentDTO());
        }
    }
}