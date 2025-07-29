// -----------------------------------------------------------------------------
// 📄 Classe: GetBlogQuery
// 📦 Namespace: Aviator.Application.Blogs.Queries.GetBlogs
//
// 🧠 O que ela faz:
// Representa uma "requisição" (query) sem parâmetros, para buscar TODOS os blogs.
//
// 🛠️ MediatR:
// Implementa a interface IRequest<List<BlogVm>>, ou seja, ao enviá-la com MediatR,
// a aplicação vai responder com uma lista de objetos `BlogVm`.
//
// 🧪 Exemplo de uso:
// var resultado = await _mediator.Send(new GetBlogQuery());
//
// ----
using MediatR;

namespace Aviator.Application.Blogs.Queries.GetBlogs;

    public class GetBlogQuery : IRequest<List<BlogVm>>
    {
        
    }