using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Settings;

namespace OpenWeatherMapNET.Configuration
{
    public static class SettingsConfiguration
    {
        /// <summary>
        /// DI for AppSettings.json configuration
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AppSettingsConfiguration(this IServiceCollection services)
            => services.AddSingleton<IOpenWeatherSettings, OpenWeatherAppSettings>();
    }
}
