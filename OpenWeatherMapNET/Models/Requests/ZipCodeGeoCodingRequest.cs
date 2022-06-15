namespace OpenWeatherMapNET.Models
{
    public class ZipCodeGeoCodingRequest : RequestBase
    {
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }

        public ZipCodeGeoCodingRequest(string zipCode, string countryCode)
        {
            ZipCode = zipCode;
            CountryCode = countryCode;
        }

        public override string ToQueryString() => $"?zip={string.Join(",", ZipCode, CountryCode)}";
    }
}
