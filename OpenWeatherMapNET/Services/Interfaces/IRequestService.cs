using OpenWeatherMapNET.Models;

namespace OpenWeatherMapNET.Services
{
    /// <summary>
    /// Perform Http requests
    /// </summary>
    public interface IRequestService
    {
        Task<HttpResponseMessage> GetAsync(string url, RequestBase request);
    }
}
