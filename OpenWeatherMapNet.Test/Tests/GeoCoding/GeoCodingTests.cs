using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMapNet.Test.Tests.Base;
using OpenWeatherMapNET.Models;
using OpenWeatherMapNET.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
