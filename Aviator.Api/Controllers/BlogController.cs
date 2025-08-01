using Aviator.Application.Blogs.Queries.GetBlogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Aviator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ApiControllerBase
    {
        // GET api/blog
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var blogs = await Mediator.Send(new GetBlogQuery());
            return Ok(blogs);
        }
    }
}