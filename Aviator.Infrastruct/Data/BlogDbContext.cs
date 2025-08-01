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