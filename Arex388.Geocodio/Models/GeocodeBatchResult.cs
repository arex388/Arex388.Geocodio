using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The geocode or reverse geocode batch result.
/// </summary>
public sealed class GeocodeBatchResult {
	/// <summary>
	/// The address being geocoded.
	/// </summary>
	[JsonPropertyName("query")]
	public string Address { get; init; } = null!;

	/// <summary>
	/// The results.
	/// </summary>
	public IList<GeocodeResult> Results { get; init; } = [];
}