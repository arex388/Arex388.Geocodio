using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US ACS families details.
/// </summary>
public sealed class UsAcsFamilies {
	/// <summary>
	/// Households details.
	/// </summary>
	[JsonPropertyName("Household type by household")]
	public UsAcsStatus Households { get; init; } = null!;

	/// <summary>
	/// Households by population details.
	/// </summary>
	[JsonPropertyName("Household type by population")]
	public UsAcsStatus Population { get; init; } = null!;

	/// <summary>
	/// Marital status details.
	/// </summary>
	[JsonPropertyName("Marital status")]
	public UsAcsStatus MaritalStatus { get; init; } = null!;
}