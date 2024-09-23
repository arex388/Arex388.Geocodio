namespace Arex388.Geocodio;

/// <summary>
/// The US Congressional legislator's details.
/// </summary>
public sealed class UsCongressionalLegislator {
	/// <summary>
	/// The legislator's bio.
	/// </summary>
	public UsCongressionalLegislatorBio Bio { get; init; } = null!;

	/// <summary>
	/// The legislator's contact.
	/// </summary>
	public UsCongressionalLegislatorContact Contact { get; init; } = null!;

	/// <summary>
	/// The legislator's references.
	/// </summary>
	public UsCongressionalLegislatorReferences References { get; init; } = null!;

	/// <summary>
	/// The legislator's social.
	/// </summary>
	public UsCongressionalLegislatorSocial Social { get; init; } = null!;

	/// <summary>
	/// The legislator's data source.
	/// </summary>
	public string Source { get; init; } = null!;

	/// <summary>
	/// The legislator's type.
	/// </summary>
	public UsCongressionalLegislatorType Type { get; init; }
}