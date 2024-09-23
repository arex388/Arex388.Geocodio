using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Congressional legislator's social.
/// </summary>
public sealed class UsCongressionalLegislatorSocial {
	/// <summary>
	/// The legislator's Facebook name.
	/// </summary>
	public string? Facebook { get; init; }

	/// <summary>
	/// The legislator's RSS feed.
	/// </summary>
	[JsonPropertyName("rss_url")]
	public Uri? Rss { get; init; }

	/// <summary>
	/// The legislator's Twitter/X handle.
	/// </summary>
	[JsonPropertyName("twitter")]
	public string? Twitter { get; init; }

	/// <summary>
	/// The legislator's YouTube handle.
	/// </summary>
	public string? YouTube { get; init; }

	/// <summary>
	/// The legislator's YouTube id.
	/// </summary>
	[JsonPropertyName("youtube_id")]
	public string? YouTubeId { get; init; }
}