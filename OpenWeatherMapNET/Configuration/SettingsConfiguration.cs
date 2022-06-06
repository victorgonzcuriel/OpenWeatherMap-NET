using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Settings;

namespace OpenWeatherMapNET.Configuration
{
    public static class SettingsConfiguration
    {
        public static IServiceCollection AppSettingsConfiguration(this IServiceCollection services)
            => services.AddSingleton<IOpenWeatherSettings, OpenWeatherAppSettings>();
    }
}
