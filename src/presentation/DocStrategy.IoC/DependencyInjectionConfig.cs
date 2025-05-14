using Microsoft.Extensions.Configuration;

namespace DocStrategy.IoC;

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
