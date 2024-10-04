using System;
namespace Toro.Infra.IoC.Settings
{
    public class AppSettings
    {
        public JwtSettings Jwt { get; set; }

        public string? HostRabbitMq { get; set; }

        public bool UseInMemoryDatabase { get; set; }

        public ConnectionStringsSettings? ConnectionStrings { get; set; }

    }
}

