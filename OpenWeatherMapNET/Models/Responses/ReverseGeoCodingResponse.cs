using System.Text.Json.Serialization;

namespace OpenWeatherMapNET.Models
{
    public class ReverseGeoCodingResponse : IResponse
    {
        public string Name { get; set; } = string.Empty;
        public Dictionary<string, string> LocalNames { get; set; } = new Dictionary<string, string>();
        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }
        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
        public string Country { get; set; } = string.Empty;
    }
}
