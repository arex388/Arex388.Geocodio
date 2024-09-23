using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US ACS social details.
/// </summary>
public sealed class UsAcsSocial {
	/// <summary>
	/// Education status details.
	/// </summary>
	[JsonPropertyName("Population by minimum level of education")]
	public UsAcsStatus EducationStatus { get; init; } = null!;

	/// <summary>
	/// Military status details.
	/// </summary>
	[JsonPropertyName("Period of military service for veterans")]
	public UsAcsStatus MilitaryStatus { get; init; } = null!;

	/// <summary>
	/// Veteran status details.
	/// </summary>
	[JsonPropertyName("Population with veteran status")]
	public UsAcsStatus VeteranStatus { get; init; } = null!;
}