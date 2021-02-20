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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("ListRental")]
        public IActionResult ListRental() 
        {
            var data = _rentalService.GetAll();

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }


        [HttpGet("ListRentalByCarId")]
        public IActionResult ListRental(int carId)
        {
            var data = _rentalService.GetByCarId(carId);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("ListByCustomerId")]
        public IActionResult ListByCustomerId(int customerId) 
        {
            var data = _rentalService.GetByCustomerId(customerId);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("GetRentalDetails")]
        public IActionResult GetRentalDetails() 
        {
            var data = _rentalService.GetByRentDetail();

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("GetRental")]
        public IActionResult GetRental(int id)
        {
            var data = _rentalService.Get(id);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpPost("AddRental")]
        public IActionResult AddRental(Rental rental) 
        {
            var data = _rentalService.Add(rental);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpPut("UpdateRental")]
        public IActionResult UpdateRental(Rental rental) 
        {
            var data = _rentalService.Update(rental);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpDelete("DeleteRental")]
        public IActionResult DeleteRental(Rental rental)
        {
            var data = _rentalService.Delete(rental);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }
    }
}
