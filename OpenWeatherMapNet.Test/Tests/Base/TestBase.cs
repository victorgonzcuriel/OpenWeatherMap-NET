using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Configuration;
using OpenWeatherMapNET.Settings;

namespace OpenWeatherMapNet.Test.Tests.Base
{
    /// <summary>
    /// Base class to initialize services on tests
    /// </summary>
    public abstract class TestBase
    {
        protected readonly IServiceProvider _provider;
        protected readonly IOpenWeatherSettings _settings;


        public TestBase()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, false)
                .Build();

            var services = new ServiceCollection()
                .AddSingleton<IConfiguration>(conf)
                .EnvironmentVariablesConfiguration()
                .AddOpenWeatherMapServices();

            _provider = services.BuildServiceProvider();
            _settings = _provider.GetService<IOpenWeatherSettings>()!;
        }
    }
}
