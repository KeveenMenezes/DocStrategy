namespace PureAbstraction.WebApi.Configurations;

public static class DependencyInjectionConfigWebApi
{
    public static IServiceCollection ResolveDependencies(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configuration);

        return services;
    }
}
