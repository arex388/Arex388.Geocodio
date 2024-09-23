using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US school district's details.
/// </summary>
public sealed class UsSchoolDistrict {
	/// <summary>
	/// The school district's highest grade.
	/// </summary>
	[JsonPropertyName("grade_high")]
	public string HighestGrade { get; init; } = null!;

	/// <summary>
	/// The school district's lowest grade. Kindergarden is KG, and Pre-Kindergarden is PK.
	/// </summary>
	[JsonPropertyName("grade_low")]
	public string LowestGrade { get; init; } = null!;

	/// <summary>
	/// The Local Education Agency's code.
	/// </summary>
	public string LeaCode { get; init; } = null!;

	/// <summary>
	/// The school district's name.
	/// </summary>
	public string Name { get; init; } = null!;
}