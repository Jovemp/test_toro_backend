using System;
namespace Toro.API.Configurations.Settings
{
    public class AppSettings
    {
        public JwtSettings Jwt { get; set; }

        public bool UseInMemoryDatabase { get; set; }

        public ConnectionStringsSettings ConnectionStrings { get; set; }

    }
}

