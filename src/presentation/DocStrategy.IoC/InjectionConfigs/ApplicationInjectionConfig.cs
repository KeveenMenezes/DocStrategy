namespace DocStrategy.IoC.InjectionConfigs;

public static class ApplicationInjectionConfig
{
    public static IServiceCollection AddApplicationService(
        this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        //Strategies
        services.AddScoped<IDocumentoContext, DocumentoContext>();
        services.AddScoped<IFornecedorStrategy, PrimeiroFornecedorStrategy>();
        services.AddScoped<IFornecedorStrategy, SegundoFornecedorStrategy>();

        return services;
    }
}
