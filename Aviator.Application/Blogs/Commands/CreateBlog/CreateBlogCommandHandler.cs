using AutoMapper;
using Aviator.Application.Blogs.Queries.GetBlogs;
using Aviator.Domain.Interface;
using MediatR;

namespace Aviator.Application.Blogs.Commands.CreateBlog;

public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    
    public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        var blogEntity = new Domain.Entities.Blogs()
        {
            Name = request.Name,
            Description = request.Description,
            Author = request.Author

        };  
       var Result = await _blogRepository.CreateAsync(blogEntity);
       return _mapper.Map<BlogVm>(Result);
       
    }
}