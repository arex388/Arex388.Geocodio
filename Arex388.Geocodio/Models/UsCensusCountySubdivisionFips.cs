using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Census county subdivision FIPS details.
/// </summary>
public sealed class UsCensusCountySubdivisionFips {
	/// <summary>
	/// The county's FIPS class code.
	/// </summary>
	[JsonPropertyName("class_code")]
	public string Code { get; init; } = null!;

	/// <summary>
	/// The county's FIPS class description.
	/// </summary>
	public string Description { get; init; } = null!;
}