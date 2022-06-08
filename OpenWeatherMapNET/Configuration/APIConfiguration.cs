using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Services;

namespace OpenWeatherMapNET.Configuration
{
    public static class APIConfiguration
    {
        /// <summary>
        /// DI services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddOpenWeatherMapServices(this IServiceCollection services)
        {
            services.AddScoped<IRequestService, RequestService>();

            return services;
        }
    }
}
