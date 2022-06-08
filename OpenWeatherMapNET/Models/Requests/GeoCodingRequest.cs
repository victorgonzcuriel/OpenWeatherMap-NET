using OpenWeatherMapNET.Attributes;

namespace OpenWeatherMapNET.Models
{
    public class GeoCodingRequest : RequestBase
    {
        [QueryName("q")]
        public string Query { get; set; }
        public int Limit { get; set; }

        public GeoCodingRequest(string query, int limit)
        {
            Query = query;
            Limit = limit;
        }
    }
}
