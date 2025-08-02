// -----------------------------------------------------------------------------
// 📄 Classe: ApiControllerBase
// 📦 Namespace: Aviator.Api.Controllers
//
// 🧠 O que ela representa:
// Uma classe base abstrata para todos os controladores que utilizam MediatR.
// Centraliza a lógica de injeção do `ISender` (MediatR).
//
// 🛠️ Como funciona:
// - Usa o `HttpContext.RequestServices` para pegar o `ISender` dinamicamente.
// - Evita repetição de código em cada controller.
//
// 🧪 Onde pode ser usada:
// - Como base de qualquer controller que use CQRS com MediatR.
// -----------------------------------------------------------------------------

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Aviator.Api.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}