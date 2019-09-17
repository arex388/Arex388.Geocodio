using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class GeocodioClient {
		private const int MaxBatchCount = 10000;

		private HttpClient Client { get; }
		private string Key { get; }
		private string EndpointVersion { get; }

		public GeocodioClient(
			HttpClient client,
			string key,
			string endpointVersion = EndpointVersions.V13) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
			Key = key ?? throw new ArgumentNullException(nameof(key));
			EndpointVersion = endpointVersion ?? throw new ArgumentNullException(nameof(endpointVersion));
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
				return null;
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
				return null;
			}

			if (request.Addresses.Count() > MaxBatchCount) {
				throw new InvalidOperationException($"You're attempting to batch geocode {request.Addresses.Count()} addresses, which is more than the permitted limit of {MaxBatchCount}");
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
				return null;
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
				return null;
			}

			if (request.Coordinates.Count > MaxBatchCount) {
				throw new InvalidOperationException($"You're attempting to batch reverse geocode {request.Coordinates.Count()} coordinates, which is more than the permitted limit of {MaxBatchCount}.");
			}

			var response = await GetResponseAsync(request);

			return JsonConvert.DeserializeObject<GeocodeBatchResponse>(response);
		}

		private async Task<string> GetResponseAsync(
			RequestBase request) {
			var endpoint = $"https://api.geocod.io/{EndpointVersion}/{request.Endpoint}&api_key={Key}";

			try {
				if (request.Method == HttpMethod.Get) {
					var response = await Client.GetAsync(endpoint);

					return await response.Content.ReadAsStringAsync();
				}

				using (var content = new StringContent(request.Body, Encoding.UTF8, "application/json")) {
					using (var message = await Client.PostAsync(endpoint, content)) {
						return await message.Content.ReadAsStringAsync();
					}
				}
			} catch (HttpRequestException) {
				return null;
			}
		}
	}
}