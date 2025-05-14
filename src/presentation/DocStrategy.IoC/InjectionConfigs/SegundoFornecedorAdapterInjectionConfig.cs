namespace DocStrategy.IoC.InjectionConfigs;

public static class SegundoFornecedorAdapterInjectionConfig
{
    public static IServiceCollection AddSegundoFornecedorAdapter(
        this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddScoped<ISegundoFornecedorAdapter, SegundoFornecedorAdapter.SegundoFornecedorAdapter>();

        return services;
    }
}
