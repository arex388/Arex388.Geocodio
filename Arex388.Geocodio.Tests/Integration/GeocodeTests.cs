using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Arex388.Geocodio.Tests;

public sealed class GeocodeTests {
	private readonly ITestOutputHelper _console;
	private readonly IGeocodioClient _geocodio;

	public GeocodeTests(
		ITestOutputHelper console) {
		var services = new ServiceCollection().AddGeocodio(new GeocodioClientOptions {
			Key = Config.Key
		}).BuildServiceProvider();

		_console = console;
		_geocodio = services.GetRequiredService<IGeocodioClient>();
	}

	[Fact]
	public async Task Multiple_Succeeds() {
		//	========================================================================
		//	Arrange
		//	========================================================================

		//	========================================================================
		//	Act
		//	========================================================================

		var geocodeBatch = await _geocodio.GeocodeManyAsync([
			"1600 Pennsylvania Ave NW, Washington, DC 20500",
			"East Capitol St NE & First St SE, Washington, DC 20004"
		]);

		_console.WriteLineWithHeader(nameof(geocodeBatch), geocodeBatch);

		//	========================================================================
		//	Assert
		//	========================================================================

		geocodeBatch.Errors.Should().BeEmpty();
		geocodeBatch.Success.Should().BeTrue();

		var first = geocodeBatch.Results.First();
		var firstResult = first.Results.First();

		firstResult.Address.Should().Be("1600 Pennsylvania Ave NW, Washington, DC 20500");
		firstResult.AccuracyScore.Should().Be(1);
		firstResult.AccuracyType.Should().Be(AccuracyType.Rooftop);
		firstResult.Point.Latitude.Should().Be(38.897675M);
		firstResult.Point.Longitude.Should().Be(-77.036547M);

		var last = geocodeBatch.Results.Last();
		var lastResult = last.Results.First();

		lastResult.Address.Should().Be("1st St SE and E Capitol St NE, Washington, DC 20003");
		lastResult.AccuracyScore.Should().Be(1);
		lastResult.AccuracyType.Should().Be(AccuracyType.Intersection);
		lastResult.Point.Latitude.Should().Be(38.889812M);
		lastResult.Point.Longitude.Should().Be(-77.005916M);
	}

	[Fact]
	public async Task Single_Succeeds() {
		//	========================================================================
		//	Arrange
		//	========================================================================

		//	========================================================================
		//	Act
		//	========================================================================

		var geocode = await _geocodio.GeocodeAsync("1600 Pennsylvania Ave NW, Washington, DC 20500");

		_console.WriteLineWithHeader(nameof(geocode), geocode);

		//	========================================================================
		//	Assert
		//	========================================================================

		geocode.Errors.Should().BeEmpty();
		geocode.Success.Should().BeTrue();

		var firstResult = geocode.Results.First();

		firstResult.Address.Should().Be("1600 Pennsylvania Ave NW, Washington, DC 20500");
		firstResult.AccuracyScore.Should().Be(1);
		firstResult.AccuracyType.Should().Be(AccuracyType.Rooftop);
		firstResult.Point.Latitude.Should().Be(38.897675M);
		firstResult.Point.Longitude.Should().Be(-77.036547M);
	}
}