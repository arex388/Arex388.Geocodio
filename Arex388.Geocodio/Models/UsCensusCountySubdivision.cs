using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Census county subdivision details.
/// </summary>
public sealed class UsCensusCountySubdivision {
	/// <summary>
	/// The county's name.
	/// </summary>
	public string Name { get; init; } = null!;

	/// <summary>
	/// The county's FIPS code.
	/// </summary>
	[JsonPropertyName("fips")]
	public string FipsCode { get; init; } = null!;

	/// <summary>
	/// The county's FIPS class.
	/// </summary>
	public UsCensusCountySubdivisionFips FipsClass { get; init; } = null!;
}