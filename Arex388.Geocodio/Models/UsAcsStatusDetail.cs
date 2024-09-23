namespace Arex388.Geocodio;

/// <summary>
/// The US ACS social status detailed breakdown.
/// </summary>
public sealed class UsAcsStatusDetail {
	/// <summary>
	/// The breakdown's name.
	/// </summary>
	public string Name { get; init; } = null!;

	/// <summary>
	/// The breakdown's count.
	/// </summary>
	public decimal Count { get; init; }

	/// <summary>
	/// The breakdown's margin of error.
	/// </summary>
	public decimal MarginOfError { get; init; }

	/// <summary>
	/// The breakdown's percentage.
	/// </summary>
	public decimal? Percentage { get; init; }
}