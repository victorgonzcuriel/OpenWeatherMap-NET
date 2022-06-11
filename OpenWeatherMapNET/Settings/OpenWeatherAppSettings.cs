using Microsoft.Extensions.Configuration;

namespace OpenWeatherMapNET.Settings
{
    /// <summary>
    /// Settings implementation from Appsettings.json
    /// </summary>
    internal class OpenWeatherAppSettings : IOpenWeatherSettings
    {
        private readonly IConfiguration _configuration;

        private readonly string _sectionName = "OpenWeatherSettings";

        public OpenWeatherAppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Token => _configuration.GetSection(_sectionName).GetSection("Token").Value;

        public int Timeout => _configuration.GetSection(_sectionName).GetValue<int>("Timeout");
    }
}
