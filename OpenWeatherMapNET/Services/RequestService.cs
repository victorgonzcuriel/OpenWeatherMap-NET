using OpenWeatherMapNET.Models;
using OpenWeatherMapNET.Models.Base;
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

        public async Task<ResponseBase<T>> Get<T>(string url, RequestBase request) where T : IResponse
        {
            using HttpClient client = new HttpClient();

            client.Timeout = new TimeSpan(0, 0, _settings.Timeout);

            var response = await client.GetAsync(url + request.ToQueryString());

            return new ResponseBase<T>(response);
        }
    }
}
