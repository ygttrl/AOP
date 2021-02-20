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
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("ListCar")]
        public IActionResult ListCar()
        {
            var data = _carService.GetAll();
            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpGet("ListCarById")]
        public IActionResult ListCar(int id)
        {
            var data = _carService.GetAll(id);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("GetCar")]
        public IActionResult GetCar(int id)
        {
            var data = _carService.Get(id);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("CarDetails")]
        public IActionResult CarDetails()
        {
            var data = _carService.GetCatDetails();
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpPost("AddCar")]
        public IActionResult AddCar(Car car)
        {
            var data = _carService.Add(car);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpPut("UpdateCar")]
        public IActionResult UpdateCar(Car car)
        {
            var data = _carService.Update(car);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpDelete("DeleteCar")]
        public IActionResult DeleteCar(Car car)
        {
            var data = _carService.Delete(car);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
    }
}
