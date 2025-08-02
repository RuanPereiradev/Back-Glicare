// -----------------------------------------------------------------------------
// 📄 Classe: BlogDbContextFactory
// 📦 Namespace: Aviator.Infrastruct.Data
//
// 🧠 O que ela representa:
// Uma fábrica usada no *design-time* (tempo de design) para criar instâncias
// do `BlogDbContext`, especialmente útil para rodar comandos EF Core no terminal.
//
// 🛠️ Como funciona:
// Implementa a interface `IDesignTimeDbContextFactory` e configura manualmente
// a conexão SQLite para ser usada nas migrations e scaffolding.
//
// 🧪 Onde pode ser usada:
// - No comando: `dotnet ef migrations add`
// - No comando: `dotnet ef database update`
// -----------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Aviator.Infrastruct.Data
{
    public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
    {
        public BlogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();

            // Mesma string usada em appsettings.json
            optionsBuilder.UseSqlite("Data Source=CleanArchitecture.db");

            return new BlogDbContext(optionsBuilder.Options);
        }
    }
}