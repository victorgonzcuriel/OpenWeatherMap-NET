using OpenWeatherMapNET.Models;
using OpenWeatherMapNET.Settings;

namespace OpenWeatherMapNET.Services
{
    /// <summary>
    /// Perform Http requests
    /// </summary>
    internal class RequestService : IRequestService
    {
        private readonly IOpenWeatherSettings _settings;

        public RequestService(IOpenWeatherSettings settings)
        {
            _settings = settings;
        }

        public async Task<HttpResponseMessage> GetAsync(string url, RequestBase request)
        {
            using HttpClient client = new HttpClient();
            client.Timeout = new TimeSpan(0, 0, _settings.Timeout);

            return await client.GetAsync(url + request.ToQueryString() + $"&appid={_settings.Token}");
        }
    }
}
