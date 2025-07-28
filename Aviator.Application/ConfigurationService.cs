using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Aviator.Application;

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