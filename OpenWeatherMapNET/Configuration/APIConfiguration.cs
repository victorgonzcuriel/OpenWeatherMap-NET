using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Services;
using OpenWeatherMapNET.Services.Interfaces;

namespace OpenWeatherMapNET.Configuration
{
    public static class APIConfiguration
    {
        public static IServiceCollection AddOpenWeatherMapServices(this IServiceCollection services)
        {
            services.AddScoped<IRequestService, RequestService>();

            return services;
        }
    }
}
