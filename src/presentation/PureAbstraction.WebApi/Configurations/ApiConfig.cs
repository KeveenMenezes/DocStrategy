namespace PureAbstraction.WebApi.Configurations;

public static class ApiConfig
{
    public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();

        services.AddCors(options =>
        {
            options.AddPolicy(
                string.Empty,
                builder =>
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
        });

        services.ResolveDependencies(configuration);

        services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new UrlSegmentApiVersionReader(),
                    new HeaderApiVersionReader("X-Api-Version"));
            })
            .AddApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

        services.AddMvc(options =>
            {
                options.Filters.Add<CoreExceptionFilter>();
                options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
            })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
    }

    public static void UseApiConfiguration(this WebApplication app, IWebHostEnvironment env)
    {
        if (app.Configuration["USE_HTTPS_REDIRECTION"] == "true")
        {
            app.UseHttpsRedirection();
        }

        app.UseRouting();

        _ = app.UseCors(string.Empty);

        app.MapControllers();
    }

    public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app, IApiVersionDescriptionProvider provider)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            provider.ApiVersionDescriptions
                .Select(description => description.GroupName)
                .ToList()
                .ForEach(groupName => options.SwaggerEndpoint($"/swagger/{groupName}/swagger.json", groupName.ToUpperInvariant()));
        });

        return app;
    }

    public class SwaggerDocumentFilter
        : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var orderedPaths = swaggerDoc.Paths
                .OrderBy(p => p.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            swaggerDoc.Paths = [];
            foreach (var path in orderedPaths)
            {
                swaggerDoc.Paths.Add(path.Key, path.Value);
            }
        }
    }
}