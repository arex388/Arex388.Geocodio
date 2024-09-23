using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US ACS housing details.
/// </summary>
public sealed class UsAcsHousing {
	/// <summary>
	/// Total count details
	/// </summary>
	[JsonPropertyName("Number of housing units")]
	public UsAcsStatus Count { get; init; } = null!;

	/// <summary>
	/// Occupancy details.
	/// </summary>
	[JsonPropertyName("Occupancy status")]
	public UsAcsStatus Occupancy { get; init; } = null!;

	/// <summary>
	/// Ownership occupied details.
	/// </summary>
	[JsonPropertyName("Ownership of occupied units")]
	public UsAcsStatus Ownership { get; init; } = null!;

	/// <summary>
	/// Owner-occupied details.
	/// </summary>
	[JsonPropertyName("Median value of owner-occupied housing units")]
	public UsAcsStatus OwnedMedianValue { get; init; } = null!;

	/// <summary>
	/// Owner occupied value details.
	/// </summary>
	[JsonPropertyName("Value of owner-occupied housing units")]
	public UsAcsStatus OwnedValues { get; init; } = null!;

	/// <summary>
	/// Unit details.
	/// </summary>
	[JsonPropertyName("Units in structure")]
	public UsAcsStatus Units { get; init; } = null!;
}