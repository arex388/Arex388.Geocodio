using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Arex388.Geocodio.Benchmarks;

[SimpleJob, MemoryDiagnoser]
public class GeocodeBenchmarks {
	private readonly IGeocodioClient _geocodio;

	public GeocodeBenchmarks() {
		var services = new ServiceCollection().AddGeocodio(new GeocodioClientOptions {
			Key = Config.Key
		}).BuildServiceProvider();

		_geocodio = services.GetRequiredService<IGeocodioClient>();
	}

	[Benchmark]
	public Task<GeocodeMany.Response> Multiple() => _geocodio.GeocodeManyAsync([
		"1600 Pennsylvania Ave NW, Washington, DC 20500",
		"East Capitol St NE & First St SE, Washington, DC 20004"
	]);

	[Benchmark]
	public Task<Geocode.Response> Single() => _geocodio.GeocodeAsync("1600 Pennsylvania Ave NW, Washington, DC 20500");
}