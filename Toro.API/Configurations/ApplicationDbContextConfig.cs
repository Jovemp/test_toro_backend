using Microsoft.EntityFrameworkCore;
using Toro.API.Configurations.Settings;
using Toro.API.Data.Contexts;

namespace Toro.API.Configurations
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
    }
}

