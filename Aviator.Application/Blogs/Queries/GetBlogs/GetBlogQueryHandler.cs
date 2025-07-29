// -----------------------------------------------------------------------------
// 📄 Classe: GetBlogQueryHandler
// 📦 Namespace: Aviator.Application.Blogs.Queries.GetBlogs
//
// 🧠 O que ela faz:
// Manipula a requisição `GetBlogQuery` e retorna todos os blogs cadastrados.
//
// ⚙️ Funciona assim:
// - Recebe a query via MediatR.
// - Usa o repositório de blogs (_blogRepository) para buscar os dados.
// - Usa AutoMapper (_mapper) para transformar a entidade em BlogVm.
// - Retorna a lista pronta para exibir na API/tela.
//
// 🔄 Depende de:
// - IBlogRepository → para acessar os dados
// - IMapper → para converter as entidades em ViewModels (BlogVm)
//
// -----------------------------------------------------------------------------
using AutoMapper;
using Aviator.Domain.Interface;
using MediatR;

namespace Aviator.Application.Blogs.Queries.GetBlogs;

public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery,List<BlogVm>>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public GetBlogQueryHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    
    public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
    {
       var blogs = await _blogRepository.GetAllBlogsAsync();
       // var blogList = blogs.Select(x => new BlogVm
       // {
       //      Author = x.Author, Name = x.Name,
       //      Description = x.Description,Id = x.Id
       // }).ToList();
       var blogList = _mapper.Map<List<BlogVm>>(blogs);
       return blogList;
    }
}