using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Arex388.Geocodio;

internal sealed class GeocodioClientFactory(
	IServiceProvider services,
	IMemoryCache cache) :
	IGeocodioClientFactory {
	private static readonly MemoryCacheEntryOptions _cacheEntryOptions = new() {
		SlidingExpiration = TimeSpan.MaxValue
	};

	private readonly IServiceProvider _services = services;
	private readonly IMemoryCache _cache = cache;

	public IGeocodioClient CreateClient(
		GeocodioClientOptions options) {
		var key = $"{nameof(Arex388)}.{nameof(Geocodio)}.Key[{options.Key}]";

		if (_cache.TryGetValue(key, out IGeocodioClient? geocodioClient)
			&& geocodioClient is not null) {
			return geocodioClient;
		}

		var httpClientFactory = _services.GetRequiredService<IHttpClientFactory>();
		var httpClient = httpClientFactory.CreateClient(nameof(IGeocodioClient));

		httpClient.BaseAddress = HttpClientHelper.BaseAddress;

		geocodioClient = new GeocodioClient(_services, httpClient, options);

		_cache.Set(key, geocodioClient, _cacheEntryOptions);

		return geocodioClient;
	}
}