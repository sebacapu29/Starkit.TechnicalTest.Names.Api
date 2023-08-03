using Microsoft.OpenApi.Models;
using Serilog;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Application.Interfaces;
using Starkit.Test.Application;
using Starkit.Test.Application.Services;
using Starkit.Test.Infrastructure.DAOs;

namespace App.Configurations
{
    public static class ConfigurationServices
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Names API", Version = "v1" });
            });

            services.AddTransient<INameService, NameService>();
            services.AddTransient<INameGateway, NameDAO>();

            Logger.ConfigureLog();
        }
    }
}
