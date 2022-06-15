using OpenWeatherMapNET.Attributes;

namespace OpenWeatherMapNET.Models
{
    public class ReverseGeoCodingRequest: RequestBase
    {
        [QueryName("lat")]
        public decimal Latitude { get; set; }
        [QueryName("lon")]
        public decimal Longitude { get; set; }
        public int Limit { get; set; }
    }
}
