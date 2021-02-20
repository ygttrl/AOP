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
    public class UsersController : ControllerBase
    {
        IUserServis _userServis;

        public UsersController(IUserServis userServis)
        {
            _userServis = userServis;
        }

        [HttpGet("ListUser")]
        public IActionResult ListUser() 
        {
            var data = _userServis.GetAll();

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpGet("ListUserById")]
        public IActionResult ListUser(int id) 
        {
            var data = _userServis.GetAll(id);
            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpGet("GetUserById")]
        public IActionResult GetUser(int id) 
        {
            var data = _userServis.GetById(id);

            if (data.Success)
            {
                return Ok(data);
            }
            return BadRequest(data.Message);
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(User user) 
        {
            var data = _userServis.Add(user);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);

        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(User user) 
        {
            var data = _userServis.Update(user);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(User user) 
        {
            var data = _userServis.Delete(user);

            if (data.Success)
            {
                return Ok(data);
            }

            return BadRequest(data.Message);
        }
    }
}
