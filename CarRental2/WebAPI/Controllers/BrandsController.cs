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
    public class BrandsController : ControllerBase
    {
        IBrandservice _brandservice;
        public BrandsController(IBrandservice brandservice)
        {
            _brandservice = brandservice;
        }

        [HttpGet("ListBrand")]
        public IActionResult ListBrand()
        {
            var data = _brandservice.GetAll();

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest();
        }

        [HttpGet("ListBrandById")]
        public IActionResult ListBrand(int id)
        {
            var data = _brandservice.GetAll(id);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpGet("GetBrand")]
        public IActionResult GetBrand(int id)
        {
            var data = _brandservice.Get(id);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpPost("AddBrand")]
        public IActionResult AddBrand(Brand brand) 
        {
            var data = _brandservice.Add(brand);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpPut("UpdateBrand")]
        public IActionResult UpdateBrand(Brand brand)
        {
            var data = _brandservice.Update(brand);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message); 
        }

        [HttpDelete("DeleteBrand")]
        public IActionResult DeleteBrand(Brand brand) 
        {
            var data = _brandservice.Delete(brand);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }
    }
}
