using OpenWeatherMapNET.Constants;
using OpenWeatherMapNET.Models;

namespace OpenWeatherMapNET.Services
{
    public class GeoCodingService : IGeoCodingService
    {
        private readonly IRequestService _requestService;
        private readonly IResponseCreationService _responseCreationService;

        public GeoCodingService(IRequestService service, IResponseCreationService responseCreationService)
        {
            _requestService = service;
            _responseCreationService = responseCreationService;
        }

        public async Task<ListResponseBase<DirectGeoCodingResponse>> DirectGeoCodingAsync(DirectGeoCodingRequest request)
        {
            var response = await _requestService.GetAsync(UrlConstants.DIRECT_GEOAPI, request);

            return await _responseCreationService.GetListResponseFromHttpResponseAsync<DirectGeoCodingResponse>(response);
        }

        public async Task<ListResponseBase<ReverseGeoCodingResponse>> ReverseGeoCodingAsync(ReverseGeoCodingRequest request)
        {
            var response = await _requestService.GetAsync(UrlConstants.REVERSE_GEOAPI, request);

            return await _responseCreationService.GetListResponseFromHttpResponseAsync<ReverseGeoCodingResponse>(response);
        }

        public async Task<SingleResponseBase<ZipCodeGeoCodingResponse>> ZipGeoCodingAsync(ZipCodeGeoCodingRequest request)
        {
            var response = await _requestService.GetAsync(UrlConstants.ZIP_GEOAPI, request);

            return await _responseCreationService.GetSingleResponseFromHttpResponseAsync<ZipCodeGeoCodingResponse>(response);
        }
    }
}
