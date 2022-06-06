namespace OpenWeatherMapNET.Settings
{
    /// <summary>
    /// API settings definition
    /// </summary>
    public interface IOpenWeatherSettings
    {
        string Token { get; }
        int Timeout { get; }
    }
}
