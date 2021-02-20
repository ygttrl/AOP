using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstruct;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("ListCustomer")]
        public IActionResult ListCustomer() 
        {
            var data = _customerService.GetAll();
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("ListCustomerById")]
        public IActionResult ListCustomer(int id)
        {
            var data = _customerService.GetAll(id);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpGet("GetUser")]
        public IActionResult GetUser(int id) 
        {
            var data = _customerService.Get(id);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(Customer Customer) 
        {
            var data = _customerService.Add(Customer);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);

        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var data = _customerService.Update(customer);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(Customer customer) 
        {
            var data = _customerService.Delete(customer);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
    }
}
