// -----------------------------------------------------------------------------
// 📄 Interface: IBlogRepository
// 📦 Namespace: Aviator.Domain.Interface
//
// 🧠 O que ela representa:
// Essa interface define o contrato para um repositório de "Blogs", ou seja,
// os métodos que qualquer classe que implemente essa interface deve ter
// para lidar com dados relacionados a blogs.
//
// 📌 Por que usar:
// - Permite separar a lógica de acesso a dados da lógica de negócios.
// - Facilita a troca ou o mock de repositórios (por exemplo, para testes).
//
// 🔧 Métodos definidos:
// - GetAllBlogsAsync(): retorna todos os blogs.
// - GetIdAsync(int id): retorna um blog específico pelo ID.
// - CreateAsync(Blogs blog): cria um novo blog.
// - UpdateAsync(int id, Blogs blog): atualiza um blog existente.
// - DeleteAsync(int id): deleta um blog pelo ID.
// -----------------------------------------------------------------------------

using Aviator.Domain.Entities;

namespace Aviator.Domain.Interface;

public interface IBlogRepository
{
    Task<List<Blogs>> GetAllBlogsAsync();
    Task<Blogs> GetIdAsync(int id);
    Task<int> CreateAsync(Blogs blog);
    Task<int> UpdateAsync(int id, Blogs blog);
    Task<int> DeleteAsync(int id);
}