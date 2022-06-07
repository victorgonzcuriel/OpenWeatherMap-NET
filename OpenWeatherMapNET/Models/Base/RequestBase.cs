using OpenWeatherMapNET.Settings;
using System.Web;

namespace OpenWeatherMapNET.Models
{
    /// <summary>
    /// Base model for HttpRequests
    /// </summary>
    internal class RequestBase
    {
        /// <summary>
        /// API key
        /// </summary>
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// Get a query string with the object information
        /// </summary>
        /// <returns></returns>
        public string ToQueryString() => "?" + string.Join("&",
            this.GetType()
                .GetProperties()
                .Where(x => x.GetType() != typeof(string) && x.GetValue(this) != null && x.GetValue(this)!.ToString() != string.Empty)
                .Select(x => $"{x.Name}={HttpUtility.UrlEncode(x.GetValue(this)!.ToString())}")
                .ToArray());
    }
}
