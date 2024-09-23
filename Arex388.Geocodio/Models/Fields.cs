namespace Arex388.Geocodio;

/// <summary>
/// Additional fields requested.
/// </summary>
public sealed class Fields {
	/// <summary>
	/// CA Census details.
	/// </summary>
	public CaCensus? CaCensus { get; init; }

	/// <summary>
	/// CA Federal riding details.
	/// </summary>
	public CaFederalRiding? CaFederalRiding { get; init; }

	/// <summary>
	/// CA Provincial riding details.
	/// </summary>
	public CaProvincialRiding? CaProvincialRiding { get; init; }

	/// <summary>
	/// Time zone details.
	/// </summary>
	public TimeZone? TimeZone { get; init; }

	/// <summary>
	/// US American Community Survey details.
	/// </summary>
	public UsAcs? UsAcs { get; init; }

	/// <summary>
	/// US Census details.
	/// </summary>
	public IList<UsCensus> UsCensus { get; init; } = [];

	/// <summary>
	/// US Congressional district details.
	/// </summary>
	public IList<UsCongressionalDistrict> UsCongressionalDistricts { get; init; } = [];

	/// <summary>
	/// US School district details.
	/// </summary>
	public UsSchoolDistricts? UsSchoolDistricts { get; init; }

	/// <summary>
	/// US State district details.
	/// </summary>
	public UsStateDistricts? UsStateDistricts { get; init; }

	/// <summary>
	/// US Zip+4 details.
	/// </summary>
	public UsZip4? UsZip4 { get; init; }
}