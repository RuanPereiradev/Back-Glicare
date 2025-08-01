// -----------------------------------------------------------------------------
// 📄 Classe estática: ConfigureServices
// 📦 Namespace: Aviator.Infrastruct
//
// 🧠 O que ela faz:
// Essa classe define um método de extensão para configurar os serviços
// da camada de infraestrutura do projeto (por exemplo, banco de dados,
// repositórios, serviços externos, etc).
//
// 🧩 Método:
// - AddInfrastructServices(IServiceCollection services, IConfiguration configuration)
//   ➤ Esse método é chamado na inicialização da aplicação (no Program.cs).
//   ➤ Aqui você registra as dependências da camada de infraestrutura.
//   ➤ Exemplo: registrar repositórios, contextos de banco, configurações, etc.
//
// 📌 Atualmente o método está vazio, mas é onde você deve adicionar:
// services.AddScoped<IBlogRepository, BlogRepository>();
//
// 🛠️ Por que usar:
// - Mantém a configuração de dependências organizada e separada por camadas.
// -----------------------------------------------------------------------------

using Aviator.Domain.Interface;
using Microsoft.EntityFrameworkCore;

using Aviator.Infrastruct.Data;
using Aviator.Infrastruct.Repositories;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Aviator.Infrastruct
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("BlogDbContext")?? 
                                  throw new InvalidOperationException("Connection string 'BlogDbContext' not found."));
            });
            services.AddTransient<IBlogRepository , BlogRepository>();
            return services;
        }
    }
}