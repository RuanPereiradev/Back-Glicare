// -----------------------------------------------------------------------------
// 📄 Classe: BlogController
// 📦 Namespace: Aviator.Api.Controllers
//
// 🧠 O que ela representa:
// Controlador da API responsável pelos endpoints relacionados a Blogs.
// Utiliza CQRS com MediatR para desacoplar a lógica de negócio da camada de apresentação.
//
// 📌 Rotas definidas:
// - GET /api/blog         → Lista todos os blogs
// - GET /api/blog/{id}    → Retorna um blog específico
// - POST /api/blog        → Cria um novo blog
//
// 🛠️ Como funciona:
// - Herda de `ApiControllerBase` para ter acesso ao `Mediator`
// - Usa comandos e queries da camada de aplicação para comunicação com a lógica de domínio
//
// 🧪 Onde pode ser usada:
// - Em requisições da interface frontend ou Postman/Insomnia
// - Para demonstrar padrões CQRS + MediatR
// -----------------------------------------------------------------------------
using Aviator.Application.Blogs.Commands.CreateBlog;
using Aviator.Application.Blogs.Queries.GetBlogById;
using Aviator.Application.Blogs.Queries.GetBlogs;
using Aviator.Domain.Interface;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id, [FromServices] IBlogRepository repo)
        {
            var blog = await Mediator.Send(new GetBlogByIdQuery() { BlogId = id });
            if (blog == null)
            {
                return NotFound();
            }

            return Ok(blog);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateBlogCommand command)
        {

            var createdBlog = await Mediator.Send(command);
            return Created($"/api/blog/{createdBlog.Id}", createdBlog);
        }


    }
}