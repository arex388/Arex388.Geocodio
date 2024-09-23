namespace Arex388.Geocodio;

/// <summary>
/// The US ACS social status details.
/// </summary>
public sealed class UsAcsStatus {
	/// <summary>
	/// The status' detailed breakdown.
	/// </summary>
	public IList<UsAcsStatusDetail> Details { get; init; } = [];

	/// <summary>
	/// The status' survey table.
	/// </summary>
	public string? SurveyTable { get; init; } = null!;

	/// <summary>
	/// The status' survey universe.
	/// </summary>
	public string? SurveyUniverse { get; init; } = null!;

	/// <summary>
	/// The status' total count.
	/// </summary>
	public decimal? TotalCount { get; init; }

	/// <summary>
	/// The status' total margin of error.
	/// </summary>
	public decimal? TotalMarginOfError { get; init; }
}