using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Arex388.Geocodio.Tests;

public sealed class ReverseGeocodeTests {
	private readonly ITestOutputHelper _console;
	private readonly IGeocodioClient _geocodio;

	public ReverseGeocodeTests(
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

		var reverseGeocodeBatch = await _geocodio.ReverseGeocodeManyAsync([
			"38.897675,-77.036547",
			"38.898976,-77.038219"
		]);

		_console.WriteLineWithHeader(nameof(reverseGeocodeBatch), reverseGeocodeBatch);

		//	========================================================================
		//	Assert
		//	========================================================================

		var first = reverseGeocodeBatch.Results.First();
		var firstResult = first.Results.First();

		firstResult.Address.Should().Be("1600 Pennsylvania Ave NW, Washington, DC 20500");
		firstResult.AccuracyScore.Should().Be(1);
		firstResult.AccuracyType.Should().Be(AccuracyType.Rooftop);
		firstResult.Point.Latitude.Should().Be(38.897675M);
		firstResult.Point.Longitude.Should().Be(-77.036547M);

		var last = reverseGeocodeBatch.Results.Last();
		var lastResult = last.Results.Last();

		lastResult.Address.Should().Be("700 Jackson Pl NW, Washington, DC 20006");
		lastResult.AccuracyScore.Should().Be(1);
		lastResult.AccuracyType.Should().Be(AccuracyType.Rooftop);
		lastResult.Point.Latitude.Should().Be(38.898976M);
		lastResult.Point.Longitude.Should().Be(-77.038219M);
	}

	[Fact]
	public async Task Single_Succeeds() {
		//	========================================================================
		//	Arrange
		//	========================================================================

		//	========================================================================
		//	Act
		//	========================================================================

		var reverseGeocode = await _geocodio.ReverseGeocodeAsync("38.897675,-77.036547");

		_console.WriteLineWithHeader(nameof(reverseGeocode), reverseGeocode);

		//	========================================================================
		//	Assert
		//	========================================================================

		reverseGeocode.Errors.Should().BeEmpty();
		reverseGeocode.Success.Should().BeTrue();

		var firstResult = reverseGeocode.Results.First();

		firstResult.Address.Should().Be("1600 Pennsylvania Ave NW, Washington, DC 20500");
		firstResult.AccuracyScore.Should().Be(1);
		firstResult.AccuracyType.Should().Be(AccuracyType.Rooftop);
		firstResult.Point.Latitude.Should().Be(38.897675M);
		firstResult.Point.Longitude.Should().Be(-77.036547M);
	}
}