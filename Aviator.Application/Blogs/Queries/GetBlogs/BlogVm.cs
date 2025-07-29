
// -----------------------------------------------------------------------------
// 📄 Classe: BlogVm
// 📦 Namespace: Aviator.Application.Blogs.Queries.GetBlogs
//
// 🧠 O que ela faz:
// Representa um "modelo de visualização" (ViewModel) de um blog, usado para 
// enviar os dados para a tela ou API, com as informações necessárias apenas.
//
// 🔁 Mapeamento:
// Implementa a interface IMapFrom<Blogs>, ou seja, o AutoMapper pode 
// automaticamente transformar um objeto `Blogs` (entidade) em um `BlogVm`.
//
// ✨ Benefício:
// Facilita o desacoplamento da camada de domínio da camada de apresentação.
//
// -----------------------------------------------------------------------------

using Aviator.Application.Common.Mappings;

namespace Aviator.Application.Blogs.Queries.GetBlogs
{
    public class BlogVm : IMapFrom<Domain.Entities.Blogs>
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}