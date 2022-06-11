namespace OpenWeatherMapNET.Settings
{
    /// <summary>
    /// Settings implementation from environtment variables
    /// </summary>
    internal class OpenWeatherEnvironmentSettings : IOpenWeatherSettings
    {
        public string Token => Environment.GetEnvironmentVariable("OpenWeather_Token") ?? String.Empty;

        public int Timeout => int.TryParse(Environment.GetEnvironmentVariable("OpenWeather_Timeout"), out int output) ? output : 0;
    }
}
