using BlogForEducation.Application.Interfaces;
using BlogForEducation.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogForEducation.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetAllUserAsync());
        }
        [HttpGet("id:int")]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> GetUserCreate([FromBody] User user)
        {
            return Created("",await _userService.CreateUserAsync(user));
        }
    }
}
