using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Census place details.
/// </summary>
public sealed class UsCensusPlace {
	/// <summary>
	/// The place's FIPS code.
	/// </summary>
	[JsonPropertyName("fips")]
	public string FipsCode { get; init; } = null!;

	/// <summary>
	/// The place's name.
	/// </summary>
	public string Name { get; init; } = null!;
}