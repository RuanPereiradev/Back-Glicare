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