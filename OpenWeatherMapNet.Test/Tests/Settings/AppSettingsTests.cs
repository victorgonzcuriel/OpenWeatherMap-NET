using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Configuration;
using OpenWeatherMapNET.Settings;

namespace OpenWeatherMapNet.Test.Tests.Settings
{
    public class AppSettingsTests
    {
        private readonly IServiceProvider _provider;
        protected readonly IOpenWeatherSettings _settings;

        // From now on, all test will run with environment settings, so this test will not inherit from TestBase
        public AppSettingsTests()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, false)
                .Build();

            var services = new ServiceCollection()
                .AddSingleton<IConfiguration>(conf)
                .AppSettingsConfiguration()
                .AddOpenWeatherMapServices();

            _provider = services.BuildServiceProvider();
            _settings = _provider.GetService<IOpenWeatherSettings>()!;
        }

        [Fact]
        public void ReadFromSettings()
        {
            Assert.True(!string.IsNullOrEmpty(_settings?.Token) && _settings.Timeout > 0);
        }

    }
}
