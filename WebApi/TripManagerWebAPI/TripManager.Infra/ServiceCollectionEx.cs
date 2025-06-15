using Common.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TripManager.Infra;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddInfraServices(this IServiceCollection services,
        IConfigurationRoot configuration)
    {
        return services
            .AddLoggingServices(configuration);
    }
}