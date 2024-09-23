using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Census details.
/// </summary>
public sealed class UsCensus {
	/// <summary>
	/// The census' block code.
	/// </summary>
	public string BlockCode { get; init; } = null!;

	/// <summary>
	/// The census' block group.
	/// </summary>
	public string BlockGroup { get; init; } = null!;

	/// <summary>
	/// 
	/// </summary>
	public UsCensusArea CombinedStatisticalArea { get; init; } = null!;

	/// <summary>
	/// The census' county FIPS code.
	/// </summary>
	[JsonPropertyName("county_fips")]
	public string CountyFipsCode { get; init; } = null!;

	/// <summary>
	/// 
	/// </summary>
	public UsCensusCountySubdivision CountySubdivision { get; init; } = null!;

	/// <summary>
	/// The census' full FIPS code.
	/// </summary>
	[JsonPropertyName("full_fips")]
	public string FullFipsCode { get; init; } = null!;

	/// <summary>
	/// 
	/// </summary>
	public UsCensusArea MetroMicroStatisticalArea { get; init; } = null!;

	/// <summary>
	/// 
	/// </summary>
	public UsCensusArea MetropolitanDivision { get; init; } = null!;

	/// <summary>
	/// The census' place.
	/// </summary>
	public UsCensusPlace? Place { get; init; }

	/// <summary>
	/// The census' data source.
	/// </summary>
	public string Source { get; init; } = null!;

	/// <summary>
	/// The census' state FIPS code.
	/// </summary>
	[JsonPropertyName("state_fips")]
	public string StateFipsCode { get; init; } = null!;

	/// <summary>
	/// The census' tract code.
	/// </summary>
	public string TractCode { get; init; } = null!;

	/// <summary>
	/// The census' year.
	/// </summary>
	[JsonPropertyName("census_year")]
	public short Year { get; init; }
}