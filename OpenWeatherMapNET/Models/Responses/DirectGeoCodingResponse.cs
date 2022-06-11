using System.Text.Json.Serialization;

namespace OpenWeatherMapNET.Models
{
    public class DirectGeoCodingResponse : IResponse
    {
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("local_names")]
        public Dictionary<string, string> LocalNames { get; set; } = new Dictionary<string, string>();
        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }
        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
    }
}
