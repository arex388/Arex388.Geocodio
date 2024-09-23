namespace Arex388.Geocodio;

/// <summary>
/// The CA federal riding details.
/// </summary>
public sealed class CaFederalRiding {
	/// <summary>
	/// The riding's code.
	/// </summary>
	public int Code { get; init; }

	/// <summary>
	/// The riding's French name.
	/// </summary>
	public string NameFrench { get; init; } = null!;

	/// <summary>
	/// The riding's English name.
	/// </summary>
	public string NameEnglish { get; init; } = null!;

	/// <summary>
	/// The riding's Open Civics Data id.
	/// </summary>
	public string OcdId { get; init; } = null!;

	/// <summary>
	/// The riding's data source.
	/// </summary>
	public string Source { get; init; } = null!;

	/// <summary>
	/// The riding's year.
	/// </summary>
	public short Year { get; init; }
}