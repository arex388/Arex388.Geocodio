using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The CA Census details.
/// </summary>
public sealed class CaCensus {
	/// <summary>
	/// The census' metropolitan area or agglomeration.
	/// </summary>
	public CaCensusArea? Cma { get; init; }

	/// <summary>
	/// The census' consolidated division.
	/// </summary>
	public CaCensusArea? ConsolidatedSubdivision { get; init; }

	/// <summary>
	/// The census' designated place.
	/// </summary>
	public CaCensusArea? DesignatedPlace { get; init; }

	/// <summary>
	/// The census' dissemination area.
	/// </summary>
	public CaCensusArea? DisseminationArea { get; init; }

	/// <summary>
	/// The census' dessimanation block.
	/// </summary>
	public CaCensusArea? DisseminationBlock { get; init; }

	/// <summary>
	/// The census' division.
	/// </summary>
	public CaCensusArea? Division { get; init; }

	/// <summary>
	/// The census' economic region.
	/// </summary>
	public string EconomicRegion { get; init; } = null!;

	/// <summary>
	/// The census' population center.
	/// </summary>
	[JsonPropertyName("population_centre")]
	public CaCensusArea? PopulationCenter { get; init; }

	/// <summary>
	/// The census' subdivision.
	/// </summary>
	public CaCensusArea? Subdivision { get; init; }

	/// <summary>
	/// The census' statistical area.
	/// </summary>
	public CaCensusArea? StatisticalArea { get; init; }

	/// <summary>
	/// The census' tract code.
	/// </summary>
	[JsonPropertyName("tract")]
	public string? TractCode { get; init; }
}