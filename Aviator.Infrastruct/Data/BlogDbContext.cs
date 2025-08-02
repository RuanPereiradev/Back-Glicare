// -----------------------------------------------------------------------------
// 📄 Classe: BlogDbContext
// 📦 Namespace: Aviator.Infrastruct.Data
//
// 🧠 O que ela representa:
// Essa classe é o *DbContext* do Entity Framework Core.
// Ela gerencia a conexão com o banco de dados e mapeia as entidades para tabelas.
//
// 🧱 Propriedades:
// - Blogs: representa a tabela "Blogs" no banco.
//
// 🛠️ Como funciona:
// Herda de `DbContext` e usa o construtor para configurar a conexão via DI.
//
// 🧪 Onde pode ser usada:
// - Na aplicação para consultar e salvar dados no banco SQLite.
// - Internamente por repositórios ou pelo EF para aplicar migrations.
// -----------------------------------------------------------------------------

using Aviator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aviator.Infrastruct.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> dbContextOptions) : base(dbContextOptions)
        {
           
        }
        public DbSet<Blogs> Blogs { get; set; }
    }
}