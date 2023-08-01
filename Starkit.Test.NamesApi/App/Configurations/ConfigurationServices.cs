using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace App.Configurations
{
    public static class ConfigurationServices
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            // ... (otros servicios)

            // Agregar Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nombre de tu API", Version = "v1" });
            });
        }
    }
}
