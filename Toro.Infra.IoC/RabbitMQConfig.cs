using System;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Toro.Application.Consumers;
using Toro.Application.Models.Request;
using Toro.Infra.IoC.Settings;

namespace Toro.Infra.IoC
{
	public static class RabbitMQConfig
	{
        public static void AddRabbitMQConfiguration(this IServiceCollection services, AppSettings appSettings)
        {
            // Logando o valor da configuração
            Console.WriteLine($"HostRabbitMq: {appSettings.HostRabbitMq}");

            // Verificação de valor nulo ou vazio
            if (string.IsNullOrWhiteSpace(appSettings.HostRabbitMq))
            {
                throw new ArgumentException("HostRabbitMq não pode ser nulo ou vazio.");
            }


            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, cfg) =>
                   {
                       cfg.Host(new Uri(appSettings.HostRabbitMq), hst =>
                       {
                           hst.Username("guest");
                           hst.Password("guest");
                       });
                       // Configurar topologia da mensage
                       cfg.Message<OrderRequestCreate>(configTopology => { });
                       cfg.ConfigureEndpoints(context);
                   });
            });
        }

        public static void AddRabbitMQServiceConfiguration(this IServiceCollection services, AppSettings appSettings)
        {
            // Logando o valor da configuração
            Console.WriteLine($"HostRabbitMq: {appSettings.HostRabbitMq}");

            // Verificação de valor nulo ou vazio
            if (string.IsNullOrWhiteSpace(appSettings.HostRabbitMq))
            {
                throw new ArgumentException("HostRabbitMq não pode ser nulo ou vazio.");
            }

            services.AddMassTransit(x =>
            {
                x.AddConsumer<OrderCreateConsumer>();
                x.AddConsumer<ProcessOrderConsumer>();
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(new Uri(appSettings.HostRabbitMq), hst =>
                    {
                        hst.Username("guest");
                        hst.Password("guest");
                    });

                    cfg.ReceiveEndpoint("create_order", e =>
                    {
                        e.ConfigureConsumer<OrderCreateConsumer>(context);
                    });

                    cfg.ReceiveEndpoint("process_order", e =>
                    {
                        e.ConfigureConsumer<ProcessOrderConsumer>(context);
                    });
                    cfg.Message<ProcessOrderRequest>(configTopology => { });
                    cfg.Message<OrderRequestCreate>(configTopology => { });
                    // Configurar topologia da mensage
                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}

