namespace Arex388.Geocodio;

/// <summary>
/// The US state's districts.
/// </summary>
public sealed class UsStateDistricts {
	/// <summary>
	/// The state's lower districts.
	/// </summary>
	public IList<UsStateDistrict2> House { get; init; } = [];

	/// <summary>
	/// The state's upper districts.
	/// </summary>
	public IList<UsStateDistrict2> Senate { get; init; } = [];
}