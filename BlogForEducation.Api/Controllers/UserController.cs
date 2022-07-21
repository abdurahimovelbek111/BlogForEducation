using BlogForEducation.Application.DTOs;
using BlogForEducation.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public async Task<IActionResult> PostUser([FromBody] UserForCreationDto userDto)
        {
            return Created("",await _userService.CreateUserAsync(userDto));
        }
        [HttpPost("id:int/blog")]
        public async Task<IActionResult> PostBlog([FromBody] BlogForCreationDto blogDto,int id)
        {
            return Created("", await _userService.CreateBlogAsync(blogDto,id));
        }
    }
}
