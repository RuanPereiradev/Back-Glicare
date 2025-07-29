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
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;

namespace Aviator.Infrastruct;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}