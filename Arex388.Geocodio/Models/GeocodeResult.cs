using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The geocode or reverse geocode result.
/// </summary>
public sealed class GeocodeResult {
	/// <summary>
	/// The accuracy score from 0.00 to 1.00. Scores of 0.80 or more are the most accurate.
	/// </summary>
	[JsonPropertyName("accuracy")]
	public decimal AccuracyScore { get; init; }

	/// <summary>
	/// The accuracy type.
	/// </summary>
	public AccuracyType AccuracyType { get; init; } = AccuracyType.None;

	/// <summary>
	/// The addresses' components.
	/// </summary>
	public AddressComponents AddressComponents { get; init; } = null!;

	/// <summary>
	/// The well-formatted address.
	/// </summary>
	[JsonPropertyName("formatted_address")]
	public string Address { get; init; } = null!;

	/// <summary>
	/// The additional fields requested, if any.
	/// </summary>
	public Fields? Fields { get; init; }

	/// <summary>
	/// The addresses' point.
	/// </summary>
	[JsonPropertyName("location")]
	public GeocodePoint Point { get; init; } = null!;

	/// <summary>
	/// The addresses' data source.
	/// </summary>
	public string? Source { get; init; }
}