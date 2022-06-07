using OpenWeatherMapNET.Models;
using OpenWeatherMapNET.Models.Base;

namespace OpenWeatherMapNET.Services
{
    /// <summary>
    /// Perform Http requests
    /// </summary>
    internal interface IRequestService
    {
        Task<ResponseBase<T>> Get<T>(string url, RequestBase request) where T : IResponse;
    }
}
