using OpenWeatherMapNET.Constants;
using OpenWeatherMapNET.Models;
using System.Text.Json;

namespace OpenWeatherMapNET.Services
{
    public class ResponseCreationService : IResponseCreationService
    {
        public async Task<ListResponseBase<T>> GetListResponseFromHttpResponseAsync<T>(HttpResponseMessage response) where T : IResponse
        {
            var output = new ListResponseBase<T>(response);

            if (response.IsSuccessStatusCode)
                output.Response = (await JsonSerializer.DeserializeAsync<List<T>>(await response.Content.ReadAsStreamAsync(), OpenWeatherSerializerOptions.SerializerOptions))!;

            return output;
        }

        /// <summary>
        /// Returns a response single instance from the content of a HTTP response
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public async Task<SingleResponseBase<T>> GetSingleResponseFromHttpResponseAsync<T>(HttpResponseMessage response) where T : IResponse
        {
            var output = new SingleResponseBase<T>(response);

            if (response.IsSuccessStatusCode)
                output.Response = (await JsonSerializer.DeserializeAsync<T>(await response.Content.ReadAsStreamAsync(), OpenWeatherSerializerOptions.SerializerOptions))!;

            return output;
        }
    }
}
