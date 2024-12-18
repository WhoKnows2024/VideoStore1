using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs.Customers;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [Route("api/Customer")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CustomerController(ApplicationDBContext context)
        {   //constructor
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Customer = _context.Customer.ToList();
            //.Select(Customer => Customer.ToCustomerDTO());
            return Ok(Customer);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById([FromRoute] int id)
        {
            var customer = _context.Customer.Find(id);

            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCustomerRequestDTO customerDTO)
        {
            var customerModel = customerDTO.ToCustomerFromCreateDTO();
            _context.Customer.Add(customerModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCustomerById), new { id = customerModel.CustId }, customerModel.ToCustomerDTO());
        }
        [HttpPut]
        [Route("{custId}")]
        public IActionResult Update([FromRoute]int custId, [FromBody] UpdateCustomerRequestDTO updateDTO)
        {
            var customerModel = _context.Customer.FirstOrDefault(c => c.CustId == custId);
            if(customerModel == null)
            {
                return NotFound();
            }
            customerModel.CustId = custId;
            customerModel.FirstName = updateDTO.FirstName;
            customerModel.LastName = updateDTO.LastName;
            customerModel.CustComment = updateDTO.CustComment;
            customerModel.DateAdded = updateDTO.DateAdded;
            customerModel.LastModified = updateDTO.LastModified;
            customerModel.LastRental = updateDTO.LastRental;
            _context.SaveChanges();
            return Ok(customerModel.ToCustomerDTO());

        }
    }
}