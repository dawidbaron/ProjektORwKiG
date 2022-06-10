using BP.Swagger.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace BP.Swagger.Extensions
{
    public static class SwaggerApplicationBuilderExtension
    {
        public static IApplicationBuilder UseSwagger(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var swaggerOptions = configuration.GetSection("Swagger").Get<SwaggerOptions>();
                options.SwaggerEndpoint(swaggerOptions.EndpointUrl, swaggerOptions.Title);
            });

            return app;
        }
    }
}
