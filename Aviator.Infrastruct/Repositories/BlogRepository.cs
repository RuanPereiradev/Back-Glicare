using Aviator.Domain.Entities;
using Aviator.Domain.Interface;
using Aviator.Infrastruct.Data;
using Microsoft.EntityFrameworkCore;

namespace Aviator.Infrastruct.Repositories;

public class BlogRepository: IBlogRepository
{
    private readonly BlogDbContext _blogDbContext;
    
    public BlogRepository(BlogDbContext blogDbContext)
    {
        _blogDbContext = blogDbContext; 
    }
    public async Task<List<Blogs>> GetAllBlogsAsync()
    {
        return await _blogDbContext.Blogs.ToListAsync();
    }

    public async  Task<Blogs> GetIdAsync(int id)
    {
        return await _blogDbContext.Blogs.AsNoTracking()
            .FirstOrDefaultAsync(b => b.Id == id);
        
    }
    public async Task<Blogs> CreateAsync(Blogs blog)
    {
        await _blogDbContext.Blogs.AddAsync(blog);
        await _blogDbContext.SaveChangesAsync();
        return blog;
    }

    public async Task<int> UpdateAsync(int id, Blogs blog)
    {
        return await _blogDbContext.Blogs
            .Where(model => model.Id == id)
            .ExecuteUpdateAsync(b => b
                .SetProperty(m => m.Name, blog.Name)
                .SetProperty(m => m.Description, blog.Description)
                .SetProperty(m => m.Author, blog.Author));
    }

    public async Task<int> DeleteAsync(int id)
    {
        return await _blogDbContext.Blogs
            .Where(model => model.Id == id)
            .ExecuteDeleteAsync();
    }
}