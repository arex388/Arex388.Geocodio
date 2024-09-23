using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US state district's details.
/// </summary>
public sealed class UsStateDistrict2 {
	[JsonInclude]
	internal string DistrictNumber { get; init; } = null!;

	/// <summary>
	/// Flag indicating if the district has be redistricted.
	/// </summary>
	[JsonPropertyName("is_upcoming_state_legislative_district")]
	public bool IsRedistricted { get; init; }

	/// <summary>
	/// The district's name.
	/// </summary>
	public string Name { get; init; } = null!;

	/// <summary>
	/// The district's number.
	/// </summary>
	public int Number => int.Parse(DistrictNumber);

	/// <summary>
	/// The district's Open Civic Data id.
	/// </summary>
	public string? OcdId { get; init; }

	/// <summary>
	/// The district's proportion.
	/// </summary>
	public int Proportion { get; init; }
}