// -----------------------------------------------------------------------------
// 📄 Classe: GetBlogByIdQuery
// 📦 Namespace: Aviator.Application.Blogs.Queries.GetBlogById
// 
// 🧠 O que ela faz:
// Essa classe representa uma "query", ou seja, um pedido para **buscar um blog pelo ID**.
//
// ✅ Como funciona:
// - Ela implementa a interface `IRequest<BlogVm>`, o que significa que será usada com o MediatR.
// - Quando essa query for enviada, o sistema deve responder com um `BlogVm` (um blog formatado).
//
// 🧪 Exemplo de uso (fictício):
// var blog = await _mediator.Send(new GetBlogByIdQuery { BlogId = 1 });
//
using Aviator.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace Aviator.Application.Blogs.Queries.GetBlogById;

public class GetBlogByIdQuery :IRequest<BlogVm>
{
    public int BlogId { get; set; }
}