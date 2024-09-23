using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Congessional district's details.
/// </summary>
public sealed class UsCongressionalDistrict {
	/// <summary>
	/// The congress number.
	/// </summary>
	public string CongressNumber { get; init; } = null!;

	/// <summary>
	/// The congress years.
	/// </summary>
	public string CongressYears { get; init; } = null!;

	/// <summary>
	/// The legislators.
	/// </summary>
	[JsonPropertyName("current_legislators")]
	public IList<UsCongressionalLegislator> Legislators { get; init; } = [];

	/// <summary>
	/// The district's name.
	/// </summary>
	public string Name { get; init; } = null!;

	/// <summary>
	/// The district's number.
	/// </summary>
	[JsonPropertyName("district_number")]
	public int Number { get; init; }

	/// <summary>
	/// The district's Open Civic Data id.
	/// </summary>
	public string OcdId { get; init; } = null!;

	/// <summary>
	/// The district's proportion.
	/// </summary>
	public int Proportion { get; init; }
}