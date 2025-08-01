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