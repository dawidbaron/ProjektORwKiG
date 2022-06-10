using BP.Swagger.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BP.Swagger.Extensions
{
    public static class SwaggerServiceCollectionExtension
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                var swaggerOptions = configuration.GetSection("Swagger").Get<SwaggerOptions>();

                options.SwaggerDoc(swaggerOptions.Name,
                    new OpenApiInfo
                    {
                        Title = swaggerOptions.Title,
                        Version = swaggerOptions.Version
                    });

            });
            return services;
        }
    }
}
