// -----------------------------------------------------------------------------
// 📄 Classe: ConfigurationService
// 📦 Namespace: Aviator.Application
//
// 🧠 O que ela faz:
// Define uma extensão de serviço para registrar automaticamente os componentes
// da camada de aplicação (como AutoMapper e MediatR) na injeção de dependência.
//
// 🛠️ Por que usar:
// Facilita a organização e centralização da configuração dos serviços usados
// na aplicação, permitindo que o `Program.cs` ou `Startup.cs` fiquem mais limpos.
//
// 🔌 O que é registrado:
// - AutoMapper: para mapeamento automático entre entidades e DTOs/ViewModels.
// - MediatR: para implementar CQRS com requests/handlers.
//
// 🧪 Exemplo de uso no Program.cs:
// builder.Services.AddApplicationServices();
//
// -----------------------------------------------------------------------------

using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Aviator.Application
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(x =>
            {
                x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}