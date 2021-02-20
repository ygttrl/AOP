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
    public class ColorsController : ControllerBase
    {
        IColorService _colorManager;

        public ColorsController(IColorService colorManager)
        {
            _colorManager = colorManager;
        }

        [HttpGet("ListColor")]
        public IActionResult ListColor()
        {
            var data = _colorManager.GetAll();
            return Ok(data.Data);
        }

        [HttpGet("ListColorById")]
        public IActionResult ListColor(int id)
        {
            if (id <= 0)
            {
                return BadRequest(_colorManager.GetAll(id).Message);
            }
            var data = _colorManager.GetAll(id);
            return Ok(data);
        }

        [HttpGet("GetId")]
        public IActionResult GetId(int id)
        {
            if (id <= 0)
            {
                var errorData = _colorManager.Get(id);
                return BadRequest(errorData.Message);
            }
            var data = _colorManager.Get(id);
            return Ok(data.Data);
        }

        [HttpPost("AddColor")]
        public IActionResult AddColor(Color color) 
        {
            var data = _colorManager.Add(color);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpPut("UpdateColor")]
        public IActionResult UpdateColor(Color color)
        {
            var data = _colorManager.Update(color);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpDelete("DeleteColor")]
        public IActionResult DeleteColor(Color color) 
        {
            var data = _colorManager.Delete(color);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }
    }
}
