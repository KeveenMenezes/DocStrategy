namespace PureAbstraction.IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDependencies(this IServiceCollection services) =>
        services
            .AddApplicationService()
            .AddPrimeiroFornecedorAdapterService()
            .AddSegundoFornecedorAdapter();
}
