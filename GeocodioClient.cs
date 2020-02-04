using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Arex388.Geocodio {
	public sealed class GeocodioClient {
		private const int MaxBatchCount = 10000;

		private HttpClient HttpClient { get; }
		private string Key { get; }

		public GeocodioClient(
			HttpClient httpClient,
			string key) {
			HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
			Key = key ?? throw new ArgumentNullException(nameof(key));
		}

		public async Task<GeocodeResponse> GetGeocodeAsync(
			string address,
			params string[] fields) => await GetGeocodeAsync(new GeocodeRequest {
				Address = address,
				Fields = fields
			});

		public async Task<GeocodeResponse> GetGeocodeAsync(
			GeocodeRequest request) {
			if (request is null) {
				return ResponseBase.Invalid<GeocodeResponse>();
			}

			var response = await GetResponseAsync(request);

			return JsonConvert.DeserializeObject<GeocodeResponse>(response);
		}

		public async Task<GeocodeBatchResponse> GetGeocodeBatchAsync(
			IList<string> addresses,
			params string[] fields) => await GetGeocodeBatchAsync(new GeocodeBatchRequest {
				Addresses = addresses,
				Fields = fields
			});

		public async Task<GeocodeBatchResponse> GetGeocodeBatchAsync(
			GeocodeBatchRequest request) {
			if (request is null) {
				return ResponseBase.Invalid<GeocodeBatchResponse>();
			}

			if (request.Addresses.Count() > MaxBatchCount) {
				throw new InvalidOperationException($"You're attempting to batch geocode {request.Addresses.Count()} addresses, which is more than the permitted limit of {MaxBatchCount}.");
			}

			var response = await GetResponseAsync(request);

			return JsonConvert.DeserializeObject<GeocodeBatchResponse>(response);
		}

		public async Task<GeocodeResponse> GetReverseGeocodeAsync(
			string location,
			params string[] fields) => await GetReverseGeocodeAsync(new ReverseGeocodeRequest {
				Fields = fields,
				Location = location
			});

		public async Task<GeocodeResponse> GetReverseGeocodeAsync(
			ReverseGeocodeRequest request) {
			if (request is null) {
				return ResponseBase.Invalid<GeocodeResponse>();
			}

			var response = await GetResponseAsync(request);

			return JsonConvert.DeserializeObject<GeocodeResponse>(response);
		}

		public async Task<GeocodeBatchResponse> GetReverseGeocodeBatchAsync(
			IList<string> coordinates,
			params string[] fields) => await GetReverseGeocodeBatchAsync(new ReverseGeocodeBatchRequest {
				Coordinates = coordinates,
				Fields = fields
			});

		public async Task<GeocodeBatchResponse> GetReverseGeocodeBatchAsync(
			ReverseGeocodeBatchRequest request) {
			if (request is null) {
				return ResponseBase.Invalid<GeocodeBatchResponse>();
			}

			if (request.Coordinates.Count > MaxBatchCount) {
				throw new InvalidOperationException($"You're attempting to batch reverse geocode {request.Coordinates.Count()} coordinates, which is more than the permitted limit of {MaxBatchCount}.");
			}

			var response = await GetResponseAsync(request);

			return JsonConvert.DeserializeObject<GeocodeBatchResponse>(response);
		}

		//	========================================================================

		private async Task<string> GetResponseAsync(
			RequestBase request) {
			var endpoint = $"https://api.geocod.io/v1.4/{request.Endpoint}&api_key={Key}";

			try {
				if (request.Method == HttpMethod.Get) {
					return await GetGetResponseAsync(request, endpoint);
				}

				return await GetPostResponseAsync(request, endpoint);
			} catch (HttpRequestException) {
				return null;
			}
		}

		private async Task<string> GetGetResponseAsync(
			RequestBase request,
			string endpoint) {
			var response = await HttpClient.GetAsync(endpoint);

#if DEBUG
			var responseContent = await response.Content.ReadAsStringAsync();

			Console.Write(responseContent);

			return responseContent;
#else
			return await response.Content.ReadAsStringAsync();
#endif
		}

		private async Task<string> GetPostResponseAsync(
			RequestBase request,
			string endpoint) {
			using var content = new StringContent(request.Body, Encoding.UTF8, "application/json");
			using var response = await HttpClient.PostAsync(endpoint, content);

#if DEBUG
			var responseContent = await response.Content.ReadAsStringAsync();

			Console.Write(responseContent);

			return responseContent;
#else
			return await response.Content.ReadAsStringAsync();
#endif
		}
	}
}