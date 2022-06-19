using OpenWeatherMapNET.Models;

namespace OpenWeatherMapNET.Services
{
    /// <summary>
    /// Creates new instances for response base models
    /// </summary>
    public interface IResponseCreationService
    {
        /// <summary>
        /// Returns a response list instance from the content of a HTTP response
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        Task<ListResponseBase<T>> GetListResponseFromHttpResponseAsync<T>(HttpResponseMessage response) where T : IResponse;

        /// <summary>
        /// Returns a response single instance from the content of a HTTP response
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        Task<SingleResponseBase<T>> GetSingleResponseFromHttpResponseAsync<T>(HttpResponseMessage response) where T : IResponse;
    }
}
