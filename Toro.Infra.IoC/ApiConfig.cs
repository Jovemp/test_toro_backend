using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Toro.Infra.IoC.Settings;

namespace Toro.Infra.IoC
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
            app.UseCors(CORS_DEV);
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseJwtConfiguration();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            return app;
        }
    }
}

