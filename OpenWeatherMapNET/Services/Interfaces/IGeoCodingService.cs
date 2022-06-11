using OpenWeatherMapNET.Models;

namespace OpenWeatherMapNET.Services
{
    public interface IGeoCodingService
    {
        /// <summary>
        /// Return data from places which match the query
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ListResponseBase<DirectGeoCodingResponse>> DirectGeoCodingAsync(DirectGeoCodingRequest request);
    }
}
