namespace Arex388.Geocodio;

/// <summary>
/// Geocod.io API client factory for interacting with multiple accounts.
/// </summary>
public interface IGeocodioClientFactory {
	/// <summary>
	/// Create and cache an instance of the Geocod.io API client.
	/// </summary>
	/// <param name="options">The client's configuration options.</param>
	/// <returns>An instance of the client.</returns>
	IGeocodioClient CreateClient(
		GeocodioClientOptions options);
}