using OpenWeatherMapNET.Constants;
using OpenWeatherMapNET.Models;

namespace OpenWeatherMapNET.Services
{
    public class GeoCodingService : IGeoCodingService
    {
        private readonly IRequestService _service;

        public GeoCodingService(IRequestService service) => _service = service;

        public async Task<ListResponseBase<DirectGeoCodingResponse>> DirectGeoCodingAsync(DirectGeoCodingRequest request)
        {
            var response = await _service.GetAsync(UrlConstants.DIRECT_GEOAPI, request);

            return new ListResponseBase<DirectGeoCodingResponse>(response);
        }

        public async Task<ListResponseBase<ReverseGeoCodingResponse>> ReverseGeoCodingAsync(ReverseGeoCodingRequest request)
        {
            var response = await _service.GetAsync(UrlConstants.REVERSE_GEOAPI, request);

            return new ListResponseBase<ReverseGeoCodingResponse>(response);
        }

        public async Task<SingleResponseBase<ZipCodeGeoCodingResponse>> ZipGeoCodingAsync(ZipCodeGeoCodingRequest request)
        {
            var response = await _service.GetAsync(UrlConstants.ZIP_GEOAPI, request);

            return new SingleResponseBase<ZipCodeGeoCodingResponse>(response);
        }
    }
}
