using System.Text.Json;

namespace OpenWeatherMapNET.Models
{
    /// <summary>
    /// Main body for response models
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ResponseBody
    {
        public readonly bool IsSuccessStatusCode;
        public readonly int StatusCode;

        public ResponseBody(HttpResponseMessage response)
        {
            IsSuccessStatusCode = response.IsSuccessStatusCode;
            StatusCode = (int)response.StatusCode;
        }
    }
}
