using OpenWeatherMapNET.Attributes;

namespace OpenWeatherMapNET.Models
{
    /// <summary>
    /// Request for GeoCoding endpoint
    /// </summary>
    public class DirectGeoCodingRequest : RequestBase
    {
        /// <summary>
        /// {city name, state code, ISO country code}
        /// </summary>
        [QueryName("q")]
        public string Query { get; set; }
        /// <summary>
        /// Search limit
        /// </summary>
        public int Limit { get; set; }

        public DirectGeoCodingRequest(string query, int limit = 0)
        {
            Query = query;
            Limit = limit;
        }
    }
}
