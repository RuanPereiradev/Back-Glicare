// -----------------------------------------------------------------------------
// 📄 Classe: GetBlogByIdQueryHandler
// 📦 Namespace: Aviator.Application.Blogs.Queries.GetBlogById
//
// 🧠 O que faz:
// Esta classe é um "Handler" do MediatR que trata a requisição `GetBlogByIdQuery`.
// Ela é responsável por buscar um blog no repositório a partir do ID recebido
// e retornar um objeto `BlogVm` mapeado com AutoMapper.
//
// ⚙️ Como funciona:
// - Recebe um `BlogId` pela requisição.
// - Usa o `IBlogRepository` para buscar o blog no banco (ou outra fonte).
// - Usa o `IMapper` para converter a entidade `Blogs` para `BlogVm`.
// - Retorna o `BlogVm` para a camada superior (ex: Controller).
//
// ✅ Útil para: Obter detalhes de um blog específico.
// -----------------------------------------------------------------------------

using AutoMapper;
using Aviator.Application.Blogs.Queries.GetBlogs;
using Aviator.Domain.Interface;
using MediatR;

namespace Aviator.Application.Blogs.Queries.GetBlogById;

public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;
    
    public GetBlogByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
    {
       var blog =  await _blogRepository.GetIdAsync(request.BlogId);
      return _mapper.Map<BlogVm>(blog);
    }
}