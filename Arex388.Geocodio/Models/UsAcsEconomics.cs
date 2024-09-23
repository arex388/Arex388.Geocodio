using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US ACS economics details.
/// </summary>
public sealed class UsAcsEconomics {
	/// <summary>
	/// Households details.
	/// </summary>
	[JsonPropertyName("Number of households")]
	public UsAcsStatus Households { get; init; } = null!;

	/// <summary>
	/// Household income details.
	/// </summary>
	[JsonPropertyName("Household income")]
	public UsAcsStatus HouseholdIncome { get; init; } = null!;

	/// <summary>
	/// Median income detials.
	/// </summary>
	[JsonPropertyName("Median household income")]
	public UsAcsStatus MedianIncome { get; init; } = null!;
}