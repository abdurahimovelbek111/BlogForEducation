using BlogForEducation.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogForEducation.Api.Controllers
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogServices _blogServices;
        public BlogController(IBlogServices blogServices)
        {
            _blogServices = blogServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetBlogs()
        {
            return Ok(await _blogServices.GetAllBlogAsync());
        }
        [HttpGet]
        [Route("id:int")]
        public async Task<IActionResult> GetBlogId(int id)
        {
            return Ok(await _blogServices.GetByIdAsync(id));
        }
    }
}
