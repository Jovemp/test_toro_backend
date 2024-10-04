using Toro.Service.Processor;
using Toro.Infra.IoC;
using Toro.Infra.IoC.Settings;

var builder = Host.CreateApplicationBuilder(args);
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

builder.Services.AddConfigDbContext(appSettings);
builder.Services.RegisterServices(appSettings);
builder.Services.AddRabbitMQServiceConfiguration(appSettings);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
