using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Arex388.Geocodio.Benchmarks;

[SimpleJob, MemoryDiagnoser]
public class ReverseGeocodeBenchmarks {
	private readonly IGeocodioClient _geocodio;

	public ReverseGeocodeBenchmarks() {
		var services = new ServiceCollection().AddGeocodio(new GeocodioClientOptions {
			Key = Config.Key
		}).BuildServiceProvider();

		_geocodio = services.GetRequiredService<IGeocodioClient>();
	}

	[Benchmark]
	public Task<ReverseGeocodeMany.Response> Multiple() => _geocodio.ReverseGeocodeManyAsync([
		"38.897675,-77.036547",
		"38.898976,-77.038219"
	]);

	[Benchmark]
	public Task<ReverseGeocode.Response> Single() => _geocodio.ReverseGeocodeAsync("38.897675,-77.036547");
}