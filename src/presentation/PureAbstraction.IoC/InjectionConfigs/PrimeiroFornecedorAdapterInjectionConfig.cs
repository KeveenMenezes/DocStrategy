namespace PureAbstraction.IoC.InjectionConfigs;

public static class PrimeiroFornecedorAdapterInjectionConfig
{
    public static IServiceCollection AddPrimeiroFornecedorAdapterService(
        this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddScoped<IPrimeiroFornecedorAdapter, PrimeiroFornecedorAdapter.PrimeiroFornecedorAdapter>();

        return services;
    }
}
