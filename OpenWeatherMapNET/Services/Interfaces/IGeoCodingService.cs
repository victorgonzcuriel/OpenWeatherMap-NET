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

        /// <summary>
        /// Return data from places with match zip and country code
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SingleResponseBase<ZipCodeGeoCodingResponse>> ZipGeoCodingAsync(ZipCodeGeoCodingRequest request);

        /// <summary>
        /// Return data from places with match latitude and longitude
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ListResponseBase<ReverseGeoCodingResponse>> ReverseGeoCodingAsync(ReverseGeoCodingRequest request);
    }
}
