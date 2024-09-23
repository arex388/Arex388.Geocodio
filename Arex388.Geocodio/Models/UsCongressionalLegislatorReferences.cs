using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Congressional legislator's public references.
/// </summary>
public sealed class UsCongressionalLegislatorReferences {
	/// <summary>
	/// The legislator's Bioguide id.
	/// </summary>
	public string? BioguideId { get; init; }

	/// <summary>
	/// The legislator's THOMAS id. NOTE: The THOMAS database has been retired since July 5th, 2016.
	/// </summary>
	public string? ThomasId { get; init; }

	/// <summary>
	/// The legislator's OpenSecret's id.
	/// </summary>
	[JsonPropertyName("opensecrets_id")]
	public string? OpenSecretsId { get; init; }

	/// <summary>
	/// The legislator's Legislative Information System id.
	/// </summary>
	public string? LisId { get; init; }

	/// <summary>
	/// The legislator's CSPAN id.
	/// </summary>
	public string? CspanId { get; init; }

	/// <summary>
	/// The legislator's GovTrack id.
	/// </summary>
	[JsonPropertyName("govtrack_id")]
	public string? GovTrackId { get; init; }

	/// <summary>
	/// The legislator's Vote Smart id.
	/// </summary>
	[JsonPropertyName("votesmart_id")]
	public string? VoteSmartId { get; init; }

	/// <summary>
	/// The legislator's Ballotpedia id.
	/// </summary>
	public string? BallotpediaId { get; init; }

	/// <summary>
	/// The legislator's Washington Post id.
	/// </summary>
	public string? WashingtonPostId { get; init; }

	/// <summary>
	/// The legislator's Inter-university Consortium for Political and Social Research id.
	/// </summary>
	public string? IcpsrId { get; init; }

	/// <summary>
	/// The legislator's Wikipedia id.
	/// </summary>
	public string? WikipediaId { get; init; }
}