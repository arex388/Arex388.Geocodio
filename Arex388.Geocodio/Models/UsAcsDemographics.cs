using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US ACS demographics details.
/// </summary>
public sealed class UsAcsDemographics {
	/// <summary>
	/// Median age details.
	/// </summary>
	[JsonPropertyName("Median age")]
	public UsAcsStatus MedianAge { get; init; } = null!;

	/// <summary>
	/// Population by age details.
	/// </summary>
	[JsonPropertyName("Population by age range")]
	public UsAcsStatus PopulationByAge { get; init; } = null!;

	/// <summary>
	/// Race and ethnicity details.
	/// </summary>
	[JsonPropertyName("Race and ethnicity")]
	public UsAcsStatus RaceEthnicity { get; init; } = null!;

	/// <summary>
	/// Sex details.
	/// </summary>
	[JsonPropertyName("Sex")]
	public UsAcsStatus Sex { get; init; } = null!;
}