using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Arex388.Geocodio.Tests;

public sealed class GeocodioClientFactoryTests {
	private readonly ITestOutputHelper _console;
	private readonly IGeocodioClientFactory _geocodioFactory;

	public GeocodioClientFactoryTests(
		ITestOutputHelper console) {
		var services = new ServiceCollection().AddGeocodio().BuildServiceProvider();

		_console = console;
		_geocodioFactory = services.GetRequiredService<IGeocodioClientFactory>();
	}

	[Fact]
	public void CreateAndCacheClient() {
		//	========================================================================
		//	Arrange
		//	========================================================================

		//	========================================================================
		//	Act
		//	========================================================================

		var created = _geocodioFactory.CreateClient(new GeocodioClientOptions {
			Key = Config.Key
		});
		var cached = _geocodioFactory.CreateClient(new GeocodioClientOptions {
			Key = Config.Key
		});

		//	========================================================================
		//	Assert
		//	========================================================================

		_console.WriteLineWithHeader(nameof(created), created);
		_console.WriteLineWithHeader(nameof(cached), cached);

		created.Should().BeSameAs(cached);
	}

	[Fact]
	public void CreateClients() {
		//	========================================================================
		//	Arrange
		//	========================================================================

		//	========================================================================
		//	Act
		//	========================================================================

		var client1 = _geocodioFactory.CreateClient(new GeocodioClientOptions {
			Key = Config.Key
		});
		var client2 = _geocodioFactory.CreateClient(new GeocodioClientOptions {
			Key = "asdf"
		});

		//	========================================================================
		//	Assert
		//	========================================================================

		_console.WriteLineWithHeader(nameof(client1), client1);
		_console.WriteLineWithHeader(nameof(client2), client2);

		client1.Should().NotBeSameAs(client2);
	}
}