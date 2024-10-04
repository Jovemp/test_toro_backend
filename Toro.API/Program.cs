using MassTransit;
using Microsoft.EntityFrameworkCore;
using Toro.Infra.Data.Contexts;
using Toro.Infra.IoC;
using Toro.Infra.IoC.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var appSettingsSection = builder.Configuration.GetSection("AppSettings");
var appSettings = appSettingsSection.Get<AppSettings>();
if (appSettings == null)
{
    appSettings = new AppSettings();
    appSettings.ConnectionStrings = new ConnectionStringsSettings();
}
if (appSettings.ConnectionStrings == null)
{
    appSettings.ConnectionStrings = new ConnectionStringsSettings();
}
appSettings.HostRabbitMq = appSettings.HostRabbitMq != null ? appSettings.HostRabbitMq : Environment.GetEnvironmentVariable("HostRabbitMq");
appSettings.ConnectionStrings.DefaultConnection = appSettings.ConnectionStrings.DefaultConnection != null ? appSettings.ConnectionStrings.DefaultConnection : Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

// Configure Services
builder.Services.Configure<AppSettings>(appSettingsSection);
builder.Services.AddApiConfiguration(appSettings);
builder.Services.AddConfigDbContext(appSettings);
builder.Services.RegisterServices(appSettings);
builder.Services.AddSwaggerConfiguration();
builder.Services.AddRabbitMQConfiguration(appSettings);

var app = builder.Build();

app.MigrateDatabase<ApplicationDbContext>();
// Configure the HTTP request pipeline.

app.UseSwaggerConfiguration();
app.UseApiConfiguration(app.Environment);


app.Run();

