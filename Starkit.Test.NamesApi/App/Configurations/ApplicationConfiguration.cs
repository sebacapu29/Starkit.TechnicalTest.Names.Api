namespace App.Configurations
{
    public static class ApplicationConfiguration
    {
        public static void Configure(this IApplicationBuilder app)
        {
            // ... (otros middlewares)

            // Habilitar Swagger
            app.UseSwagger();

            // Especificar la ruta de la interfaz de usuario de Swagger (por ejemplo, /swagger)
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nombre de tu API V1");
            });

            // ... (más configuraciones y middlewares)
        }
    }
}
