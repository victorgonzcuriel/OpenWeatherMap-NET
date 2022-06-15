using System.Text.Json.Serialization;

namespace OpenWeatherMapNET.Models
{
    public class ZipCodeGeoCodingResponse : IResponse
    {
        public string Zip { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("lat")]
        public decimal Latitude { get; set; }
        [JsonPropertyName("lon")]
        public decimal Longitude { get; set; }
        public string Country { get; set; }

        public ZipCodeGeoCodingResponse(string zip, string name, decimal latitude, decimal longitude, string country)
        {
            Zip = zip;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Country = country;
        }
    }
}
