namespace Arex388.Geocodio;

/// <summary>
/// The US American Community Survey (ACS) from Census details.
/// </summary>
public sealed class UsAcs {
	/// <summary>
	/// Demographic details.
	/// </summary>
	public UsAcsDemographics? Demographics { get; init; }

	/// <summary>
	/// Economics details.
	/// </summary>
	public UsAcsEconomics? Economics { get; init; }

	/// <summary>
	/// Household details.
	/// </summary>
	public UsAcsFamilies? Families { get; init; }

	/// <summary>
	/// Housing details.
	/// </summary>
	public UsAcsHousing? Housing { get; init; }

	/// <summary>
	/// Social details.
	/// </summary>
	public UsAcsSocial? Social { get; init; }

	/// <summary>
	/// The servey's data source.
	/// </summary>
	public string? Source { get; init; }

	/// <summary>
	/// The survey's duration in years.
	/// </summary>
	public byte? SurveyDuration { get; init; }

	/// <summary>
	/// The survey's years.
	/// </summary>
	public string? SurveyYears { get; init; }
}