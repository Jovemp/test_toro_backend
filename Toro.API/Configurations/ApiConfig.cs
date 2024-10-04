using FluentValidation;
using FluentValidation.AspNetCore;

using Toro.API.Configurations.Settings;

namespace Toro.API.Configurations
{
	public static class ApiConfig
	{
        public const string CORS_DEV = "Development";
        public const string CORS_PRD = "Production";

        public static IServiceCollection AddApiConfiguration(this IServiceCollection services, AppSettings appSettings)
        {
            services
                .AddControllers();

            services.AddEndpointsApiExplorer();

            // Set Fluent Validation
            services.AddFluentValidationAutoValidation();

            // Set Cors
            services.AddCors(options =>
            {
                options.AddPolicy(CORS_DEV,
                    policy =>
                        policy
                            .SetIsOriginAllowed(origin => true)
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowCredentials());
            });

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseCors(CORS_DEV);
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseCors(CORS_PRD);
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseJwtConfiguration();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            return app;
        }
    }
}

