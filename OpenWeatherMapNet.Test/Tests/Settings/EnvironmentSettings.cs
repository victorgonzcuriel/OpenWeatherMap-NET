using OpenWeatherMapNet.Test.Tests.Base;

namespace OpenWeatherMapNet.Test.Tests.Settings
{
    public class EnvironmentSettings : TestBase
    {

        public EnvironmentSettings() : base()
        {
            
        }

        [Fact]
        public void ReadFromSettings()
        {
            Assert.True(!string.IsNullOrEmpty(_settings?.Token) && _settings.Timeout > 0);
        }
    }
}
