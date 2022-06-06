using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNET.Configuration;
using OpenWeatherMapNET.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapNet.Test.Tests.Settings
{
    public class AppSettingsTests
    {
        private readonly IServiceProvider _provider;

        public AppSettingsTests()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, false)
                .Build();

            var services = new ServiceCollection()
                .AddSingleton<IConfiguration>(conf)
                .AppSettingsConfiguration();

            _provider = services.BuildServiceProvider();
        }

        [Fact]
        public void ReadFromSettings()
        {
            var settings = _provider.GetService<IOpenWeatherSettings>();

            Assert.True(!string.IsNullOrEmpty(settings?.Token) && settings.Timeout > 0);
        }
        
    }
}
