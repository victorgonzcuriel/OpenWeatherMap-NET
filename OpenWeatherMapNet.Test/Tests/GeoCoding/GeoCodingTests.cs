using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNet.Test.Tests.Base;
using OpenWeatherMapNET.Models;
using OpenWeatherMapNET.Services;

namespace OpenWeatherMapNet.Test.Tests.GeoCoding
{
    public class GeoCodingTests : TestBase
    {

        public GeoCodingTests() : base()
        {

        }

        [Fact]
        public async Task GetDataFromDirectGeocoding()
        {
            var service = _provider.GetService<IGeoCodingService>()!;

            var request = new DirectGeoCodingRequest("Cartagena");

            var response = await service.DirectGeoCodingAsync(request);

            Assert.True(response != null && response.IsSuccessStatusCode && response.Response.Any());
        }

        [Fact]
        public async Task GetDataFromZipGeocoding()
        {
            var service = _provider.GetService<IGeoCodingService>()!;

            var request = new ZipCodeGeoCodingRequest("28342", "ES");

            var response = await service.ZipGeoCodingAsync(request);

            Assert.True(response != null && response.IsSuccessStatusCode && response.Response != null);
        }

        [Fact]
        public async Task GetDataFromReverseGeocoding()
        {
            var service = _provider.GetService<IGeoCodingService>()!;

            var request = new ReverseGeoCodingRequest
            {
                Latitude = 51.5098M,
                Longitude = -0.1180M,
                Limit = 1
            };

            var response = await service.ReverseGeoCodingAsync(request);

            Assert.True(response != null && response.IsSuccessStatusCode && response.Response.Any());
        }
    }
}
