using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arex388.Geocodio {
    /// <summary>
    /// Geocod.io API client. TEST
    /// </summary>
    public sealed class GeocodioClient :
        IGeocodioClient {
        private const int MaxBatchSize = 10000;

        private readonly bool _debug;
        private readonly HttpClient _httpClient;
        private readonly string _key;

        /// <summary>
        /// Create an instance of the Geocod.io API client.
        /// </summary>
        /// <param name="httpClient">An instance of HttpClient.</param>
        /// <param name="key">Your Geocod.io API key.</param>
        /// <param name="debug">Toggle response debugging. Disabled by default.</param>
        public GeocodioClient(
            HttpClient httpClient,
            string key,
            bool debug = false) {
            _debug = debug;
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _key = key ?? throw new ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Geocode an address.
        /// </summary>
        /// <param name="address">The address to geocode.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeResponse</returns>
        public async Task<GeocodeResponse> GeocodeAsync(
            string address,
            CancellationToken cancellationToken = default) => await GeocodeAsync(address, Enumerable.Empty<string>(), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Geocode an address.
        /// </summary>
        /// <param name="address">The address to geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeResponse</returns>
        public async Task<GeocodeResponse> GeocodeAsync(
            string address,
            IEnumerable<string> fields,
            CancellationToken cancellationToken = default) => await GeocodeAsync(new GeocodeRequest {
                Address = address,
                Fields = fields
            }, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Geocode an address.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeResponse</returns>
        public async Task<GeocodeResponse> GeocodeAsync(
            GeocodeRequest request,
            CancellationToken cancellationToken = default) {
            if (request is null) {
                return InvalidResponse<GeocodeResponse>();
            }

            if (cancellationToken.IsCancellationRequested) {
                return CancelledResponse2<GeocodeResponse>();
            }

            return await RequestAsync<GeocodeResponse>(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Geocode a batch of addresses.
        /// </summary>
        /// <param name="addresses">The addresses to geocode.</param>
        /// <param name="cancellationToken">The cancellation token/</param>
        /// <returns>GeocodeBatchResponse</returns>
        public async Task<GeocodeBatchResponse> GeocodeBatchAsync(
            IEnumerable<string> addresses,
            CancellationToken cancellationToken) => await GeocodeBatchAsync(addresses, Enumerable.Empty<string>(), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Geocode a batch of addresses.
        /// </summary>
        /// <param name="addresses">The addresses to geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeBatchResponse</returns>
        public async Task<GeocodeBatchResponse> GeocodeBatchAsync(
            IEnumerable<string> addresses,
            IEnumerable<string> fields,
            CancellationToken cancellationToken = default) => await GeocodeBatchAsync(new GeocodeBatchRequest {
                Addresses = addresses,
                Fields = fields
            }, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Geocode a batch of addresses.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeBatchResponse</returns>
        public async Task<GeocodeBatchResponse> GeocodeBatchAsync(
            GeocodeBatchRequest request,
            CancellationToken cancellationToken = default) {
            if (request is null) {
                return InvalidResponse<GeocodeBatchResponse>();
            }

            if (request.Addresses.Count() > MaxBatchSize) {
                return InvalidBatchSizeResponse<GeocodeBatchResponse>();
            }

            if (cancellationToken.IsCancellationRequested) {
                return CancelledResponse2<GeocodeBatchResponse>();
            }

            return await RequestAsync<GeocodeBatchResponse>(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Reverse geocode a coordinate.
        /// </summary>
        /// <param name="coordinates">The coordinate to reverse geocode.</param>
        /// <param name="cancellationToken">The cancellation token/</param>
        /// <returns>GeocodeResponse</returns>
        public async Task<GeocodeResponse> ReverseGeocodeAsync(
            string coordinates,
            CancellationToken cancellationToken) => await ReverseGeocodeAsync(coordinates, Enumerable.Empty<string>(), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reverse geocode a coordinate.
        /// </summary>
        /// <param name="coordinates">The coordinate to reverse geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeResponse</returns>
        public async Task<GeocodeResponse> ReverseGeocodeAsync(
            string coordinates,
            IEnumerable<string> fields,
            CancellationToken cancellationToken = default) => await ReverseGeocodeAsync(new ReverseGeocodeRequest {
                Fields = fields,
                Coordinates = coordinates
            }, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reverse geocode a coordinate.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeResponse</returns>
        public async Task<GeocodeResponse> ReverseGeocodeAsync(
            ReverseGeocodeRequest request,
            CancellationToken cancellationToken = default) {
            if (request is null) {
                return InvalidResponse<GeocodeResponse>();
            }

            if (cancellationToken.IsCancellationRequested) {
                return CancelledResponse2<GeocodeResponse>();
            }

            return await RequestAsync<GeocodeResponse>(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Reverse geocode a batch of coordinates.
        /// </summary>
        /// <param name="coordiantes">The coordinates to reverse geocode.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeBatchResponse</returns>
        public async Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
            IEnumerable<string> coordiantes,
            CancellationToken cancellationToken) => await ReverseGeocodeBatchAsync(coordiantes, Enumerable.Empty<string>(), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reverse geocode a batch of coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates to reverse geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeBatchResponse</returns>
        public async Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
            IEnumerable<string> coordinates,
            IEnumerable<string> fields,
            CancellationToken cancellationToken = default) => await ReverseGeocodeBatchAsync(new ReverseGeocodeBatchRequest {
                Coordinates = coordinates,
                Fields = fields
            }, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reverse geocode a batch of coordinates.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>GeocodeBatchResponse</returns>
        public async Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
            ReverseGeocodeBatchRequest request,
            CancellationToken cancellationToken = default) {
            if (request is null) {
                return InvalidResponse<GeocodeBatchResponse>();
            }

            if (request.Coordinates.Count() > MaxBatchSize) {
                return InvalidBatchSizeResponse<GeocodeBatchResponse>();
            }

            if (cancellationToken.IsCancellationRequested) {
                return CancelledResponse2<GeocodeBatchResponse>();
            }

            return await RequestAsync<GeocodeBatchResponse>(request, cancellationToken).ConfigureAwait(false);
        }

        //  ========================================================================
        //  Response
        //	========================================================================

        private T Deserialize<T>(
            ResponseResult result)
            where T : ResponseBase, new() {
            var json = result.Json;

            if (!json.HasValue()) {
                return FailureResponse2<T>();
            }

            var response = JsonConvert.DeserializeObject<T>(json);

            if (response is null) {
                return FailureResponse2<T>();
            }

            response.ResponseJson = _debug
                ? json
                : null;
            response.ResponseStatus = result.Success
                ? ResponseStatus.Success
                : ResponseStatus.Failure;

            return response;
        }

        private async Task<HttpResponseMessage> GetAsync(
            RequestBase request,
            CancellationToken cancellationToken) => await _httpClient.GetAsync($"{request.EndpointWithPayload}&api_key={_key}", cancellationToken).ConfigureAwait(false);

        private async Task<HttpResponseMessage> PostAsync(
            RequestBase request,
            CancellationToken cancellationToken) {
            using var content = new StringContent(request.Body, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync($"{request.EndpointWithPayload}&api_key={_key}", content, cancellationToken).ConfigureAwait(false);
        }

        private async Task<T> RequestAsync<T>(
            RequestBase request,
            CancellationToken cancellationToken)
            where T : ResponseBase, new() {
            if (cancellationToken.IsCancellationRequested) {
                return CancelledResponse2<T>();
            }

            try {
                var response = request.Method == HttpMethod.Get
                    ? await GetAsync(request, cancellationToken).ConfigureAwait(false)
                    : await PostAsync(request, cancellationToken).ConfigureAwait(false);

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var success = response.StatusCode == HttpStatusCode.OK;

                return Deserialize<T>(new ResponseResult(json, success));
            } catch (HttpRequestException) {
                return FailureResponse2<T>();
            } catch (TaskCanceledException) {
                return TimeOutResponse<T>();
            }
        }

        //  ========================================================================
        //  Utilities
        //  ========================================================================

        private static T CancelledResponse2<T>()
            where T : ResponseBase, new() => new() {
                ResponseError = "The request was cancelled",
                ResponseStatus = ResponseStatus.Cancelled
            };

        private static T FailureResponse2<T>()
            where T : ResponseBase, new() => new() {
                ResponseError = "The request failed.",
                ResponseStatus = ResponseStatus.Failure
            };

        private static T InvalidResponse<T>()
            where T : ResponseBase, new() => new() {
                ResponseError = "The request is invalid.",
                ResponseStatus = ResponseStatus.Invalid
            };

        private static T InvalidBatchSizeResponse<T>()
            where T : ResponseBase, new() => new() {
                ResponseError = $"The requests's batch size is invalid. The maximum batch size allowed is {MaxBatchSize}.",
                ResponseStatus = ResponseStatus.InvalidBatchSize
            };

        private static T TimeOutResponse<T>()
            where T : ResponseBase, new() => new() {
                ResponseError = "The request timed out.",
                ResponseStatus = ResponseStatus.TimeOut
            };
    }
}