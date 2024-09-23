namespace Arex388.Geocodio;

/// <summary>
/// The US state's school districts.
/// </summary>
public sealed class UsSchoolDistricts {
	/// <summary>
	/// The state's elementary school districts.
	/// </summary>
	public UsSchoolDistrict? Elementary { get; init; }

	/// <summary>
	/// The state's secondary school districts.
	/// </summary>
	public UsSchoolDistrict? Secondary { get; init; }

	/// <summary>
	/// The state's unified school districts.
	/// </summary>
	public UsSchoolDistrict? Unified { get; init; }
}