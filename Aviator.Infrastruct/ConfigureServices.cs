using AutoMapper;
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