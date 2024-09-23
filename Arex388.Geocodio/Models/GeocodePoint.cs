using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The point of the address.
/// </summary>
public sealed class GeocodePoint {
	/// <summary>
	/// The latitude.
	/// </summary>
	[JsonPropertyName("lat")]
	public decimal Latitude { get; init; }

	/// <summary>
	/// The longitude.
	/// </summary>
	[JsonPropertyName("lng")]
	public decimal Longitude { get; init; }
}