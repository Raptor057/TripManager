using Common.CleanArch;

namespace TripManager.Web.Api;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, true)
            .Build();

        return services
            .AddSingleton(config)
            //.AddInfraServices(config)
            .AddSingleton(typeof(ResultViewModel<>))
            .AddSingleton(typeof(GenericViewModel<>))
            //.AddAppServices()
            //.AddMediatR(typeof(ServiceCollectionEx).Assembly);
            .AddMediatR(cfg =>{cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionEx).Assembly);});

    }
}