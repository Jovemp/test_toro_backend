using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Toro.Application.Account.Services;
using Toro.Application.Bond.Services;
using Toro.Application.Interfaces;
using Toro.Application.Mappings;
using Toro.Application.Order.Service;
using Toro.Application.RabbitMQ.Services;
using Toro.Domain.Repositories;
using Toro.Infra.Data.Repositories.Base;
using Toro.Infra.IoC.Settings;

namespace Toro.Infra.IoC
{
	public static class DepedencyInjectionConfig
	{
        public static IServiceCollection RegisterServices(this IServiceCollection services, AppSettings appSettings)
        {
            // Register Services
            services.AddScoped<IBondService, BondService>();
            services.AddScoped<IMessageSenderService, MessageSenderService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IOrderService, OrderService>();

            // Register Repositories 
            services.AddScoped<IUow, Uow>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            // Register Http
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}

