﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Arex388.Geocodio {
    public sealed class GeocodioClient {
        /// <summary>
        /// The maximum number of coordiantes allowed for a batch request.
        /// </summary>
        private const int MaxBatchCount = 10000;

        /// <summary>
        /// Is debugging enabled.
        /// </summary>
        private bool Debug { get; }

        /// <summary>
        /// An instance of HttpClient.
        /// </summary>
        private HttpClient HttpClient { get; }

        /// <summary>
        /// Your geocod.io API key.
        /// </summary>
        private string Key { get; }

        /// <summary>
        /// Geocod.io API client.
        /// </summary>
        /// <param name="httpClient">An instance of HttpClient.</param>
        /// <param name="key">Your geocod.io API key.</param>
        /// <param name="debug">Toggle capturing the raw JSON response from Geocod.io and returning it as part of the deserialized response object.</param>
        public GeocodioClient(
            HttpClient httpClient,
            string key,
            bool debug = false) {
            Debug = debug;
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            Key = key ?? throw new ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Geocode an address.
        /// </summary>
        /// <param name="address">The address to geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <returns>A GeocodeResponse.</returns>
        public Task<GeocodeResponse> GeocodeAsync(
            string address,
            params string[] fields) => GeocodeAsync(new GeocodeRequest {
                Address = address,
                Fields = fields
            });

        /// <summary>
        /// Geocode an address.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <returns>A GeocodeResponse.</returns>
        public async Task<GeocodeResponse> GeocodeAsync(
            GeocodeRequest request) {
            if (request is null) {
                return InvalidRequestResponse<GeocodeResponse>();
            }

            var response = await GetResponseAsync(request);
            var responseObj = JsonConvert.DeserializeObject<GeocodeResponse>(response);

            if (Debug) {
                responseObj.Json = response;
            }

            return responseObj;
        }

        /// <summary>
        /// Geocode a batch of addresses.
        /// </summary>
        /// <param name="addresses">The addresses to geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <returns>A GeocodeResponse.</returns>
        public Task<GeocodeBatchResponse> GeocodeBatchAsync(
            IList<string> addresses,
            params string[] fields) => GeocodeBatchAsync(new GeocodeBatchRequest {
                Addresses = addresses,
                Fields = fields
            });

        /// <summary>
        /// Geocode a batch of addresses.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <returns>A GeocodeResponse.</returns>
        public async Task<GeocodeBatchResponse> GeocodeBatchAsync(
            GeocodeBatchRequest request) {
            if (request is null) {
                return InvalidRequestResponse<GeocodeBatchResponse>();
            }

            if (request.Addresses.Count > MaxBatchCount) {
                return InvalidBatchCountResponse<GeocodeBatchResponse>();
            }

            var response = await GetResponseAsync(request);
            var responseObj = JsonConvert.DeserializeObject<GeocodeBatchResponse>(response);

            if (Debug) {
                responseObj.Json = response;
            }

            return responseObj;
        }

        /// <summary>
        /// Reverse geocode a coordinate.
        /// </summary>
        /// <param name="location">The coordiante to reverse geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <returns>A GeocodeResponse.</returns>
        public Task<GeocodeResponse> ReverseGeocodeAsync(
            string location,
            params string[] fields) => ReverseGeocodeAsync(new ReverseGeocodeRequest {
                Fields = fields,
                Location = location
            });

        /// <summary>
        /// Reverse geocode a coordinate.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <returns>A GeocodeResponse.</returns>
        public async Task<GeocodeResponse> ReverseGeocodeAsync(
            ReverseGeocodeRequest request) {
            if (request is null) {
                return InvalidRequestResponse<GeocodeResponse>();
            }

            var response = await GetResponseAsync(request);
            var responseObj = JsonConvert.DeserializeObject<GeocodeResponse>(response);

            if (Debug) {
                responseObj.Json = response;
            }

            return responseObj;
        }

        /// <summary>
        /// Reverse geocode a batch of coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates to reverse geocode.</param>
        /// <param name="fields">Optional fields to expand in the response.</param>
        /// <returns>A GeocodeResponse.</returns>
        public Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
            IList<string> coordinates,
            params string[] fields) => ReverseGeocodeBatchAsync(new ReverseGeocodeBatchRequest {
                Coordinates = coordinates,
                Fields = fields
            });

        /// <summary>
        /// Reverse geocode a batch of coordinates.
        /// </summary>
        /// <param name="request">A GeocodeRequest instance.</param>
        /// <returns>A GeocodeResponse.</returns>
        public async Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
            ReverseGeocodeBatchRequest request) {
            if (request is null) {
                return InvalidRequestResponse<GeocodeBatchResponse>();
            }

            if (request.Coordinates.Count > MaxBatchCount) {
                return InvalidBatchCountResponse<GeocodeBatchResponse>();
            }

            var response = await GetResponseAsync(request);
            var responseObj = JsonConvert.DeserializeObject<GeocodeBatchResponse>(response);

            if (Debug) {
                responseObj.Json = response;
            }

            return responseObj;
        }

        //  ========================================================================
        //  Response
        //	========================================================================

        private const string TimedOutResponse = "{{\"error\":\"The connection has timed out\",\"success\":false}}";

        private async Task<string> GetResponseAsync(
            RequestBase request) {
            var endpoint = $"https://api.geocod.io/v1.4/{request.Endpoint}&api_key={Key}";

            try {
                if (request.Method == HttpMethod.Get) {
                    return await GetGetResponseAsync(endpoint);
                }

                return await GetPostResponseAsync(
                    request,
                    endpoint);
            } catch (HttpRequestException e) {
                var error = $"{e.Message}\n{e.InnerException?.Message}".Trim();

                return $"{{\"error\":\"{error}\",\"success\":false}}";
            } catch (TaskCanceledException) {
                return TimedOutResponse;
            }
        }

        private async Task<string> GetGetResponseAsync(
            string endpoint) {
            var response = await HttpClient.GetAsync(endpoint);

            return await response.Content.ReadAsStringAsync();
        }

        private async Task<string> GetPostResponseAsync(
            RequestBase request,
            string endpoint) {
            using var content = new StringContent(request.Body, Encoding.UTF8, "application/json");
            using var response = await HttpClient.PostAsync(endpoint, content);

            return await response.Content.ReadAsStringAsync();
        }

        //  ========================================================================
        //  Utilities
        //  ========================================================================

        /// <summary>
        /// A failure due to over max number of allowed coordiantes per request.
        /// </summary>
        /// <typeparam name="T">The response type.</typeparam>
        /// <returns>The response.</returns>
        private static T InvalidBatchCountResponse<T>()
            where T : ResponseBase, new() => ResponseBase.Invalid<T>($"You can only geocode {MaxBatchCount} coordinates per request.");

        /// <summary>
        /// A failure due to a null request.
        /// </summary>
        /// <typeparam name="T">The response type.</typeparam>
        /// <returns>The response.</returns>
        private static T InvalidRequestResponse<T>()
            where T : ResponseBase, new() => ResponseBase.Invalid<T>("The request is invalid.");
    }
}