using System;
using Toro.API.Configurations.Settings;
using Toro.API.Data.Repositories.Base;
using Toro.API.Domain.Repositories;

namespace Toro.API.Configurations
{
    public static class DepedencyInjectionConfig
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, AppSettings appSettings)
        {
            // Register Services
            //services.AddScoped<IExempleService, ExempleService>();

            // Register Repositories 
            services.AddScoped<IUow, Uow>();
            //services.AddTransient<IExempleRepository, ExempleRepository>();

            // Register Http
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}

