using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Toro.Infra.Data.Contexts;
using Toro.Infra.IoC.Settings;

namespace Toro.Infra.IoC
{
    public static class DbContextConfig
    {
        public static void AddConfigDbContext(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                if (appSettings.UseInMemoryDatabase)
                {
                    // Usar banco de dados em memória para desenvolvimento ou testes
                    options.UseInMemoryDatabase("Toro");
                }
                else
                {
                    // Usar SQL Server (ou outro banco de dados real) em produção
                    options.UseSqlServer(appSettings.ConnectionStrings.DefaultConnection, sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly("Toro.API"); // Substitua pelo seu assembly de migrações
                    });
                }

                options.LogTo(Console.WriteLine, LogLevel.Information)
                       .EnableSensitiveDataLogging()
                       .EnableDetailedErrors();
            });
        }

        public static void MigrateDatabase<T>(this IApplicationBuilder app) where T : DbContext
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<T>();

            dbContext.Database.Migrate(); // Aplica as migrações pendentes
        }
    }
}

