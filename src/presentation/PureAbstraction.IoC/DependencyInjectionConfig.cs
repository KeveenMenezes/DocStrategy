using Microsoft.Extensions.Configuration;

namespace PureAbstraction.IoC;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDependencies(
        this IServiceCollection services,
        IConfiguration configuration) =>
        services
            .AddApplicationService()
            .AddPrimeiroFornecedorAdapterService()
            .AddSegundoFornecedorAdapter();
}
