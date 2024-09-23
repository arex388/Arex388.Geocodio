namespace Arex388.Geocodio;

/// <summary>
/// Geocod.io API configuration options.
/// </summary>
public sealed class GeocodioClientOptions {
	/// <summary>
	/// The API key.
	/// </summary>
	public required string Key { get; init; }
}