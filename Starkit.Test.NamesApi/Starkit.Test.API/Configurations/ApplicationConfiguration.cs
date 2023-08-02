namespace App.Configurations
{
    public static class ApplicationConfiguration
    {
        public static void Configure(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Names API V1");
            });
        }
    }
}
