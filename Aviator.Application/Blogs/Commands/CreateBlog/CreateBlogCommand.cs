// -----------------------------------------------------------------------------
// 📄 Classe: CreateBlogCommand
// 📦 Namespace: Aviator.Application.Blogs.Commands.CreateBlog
//
// 🧠 O que faz:
// Define os dados que serão enviados na requisição para criar um novo blog.
// Essa classe implementa `IRequest<BlogVm>`, indicando que, ao ser processada,
// o sistema deve retornar um `BlogVm` como resposta.
//
// 📝 Propriedades:
// - Id: identificador do blog (pode ser ignorado na criação dependendo do banco)
// - Name, Description, Author: informações do novo blog a ser criado
//
// ⚙️ Essa classe será manipulada por um `Handler` que irá criar o blog no banco,
// e retornar um BlogVm com os dados criados.
//
// ✅ Útil para: Criar um novo blog via endpoint.
// -----------------------------------------------------------------------------

using Aviator.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace Aviator.Application.Blogs.Commands.CreateBlog;

public class CreateBlogCommand : IRequest<BlogVm>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    
}