using System.Text.Json;

namespace OpenWeatherMapNET.Models.Base
{
    /// <summary>
    /// Base class for response models
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseBase<T> where T : IResponse
    {
        public readonly bool IsSuccessStatusCode;
        public readonly int StatusCode;
        public readonly T? Response;

        public ResponseBase(HttpResponseMessage response)
        {
            IsSuccessStatusCode = response.IsSuccessStatusCode;
            StatusCode = (int)response.StatusCode;
            if (response.IsSuccessStatusCode)
                Response = JsonSerializer.Deserialize<T>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }
    }
}
