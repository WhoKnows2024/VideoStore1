using api.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/invComment")]
    [ApiController]
    
    public class InvCommentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

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

    }
}