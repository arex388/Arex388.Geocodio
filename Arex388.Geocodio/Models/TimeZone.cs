using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// Time zone details.
/// </summary>
public sealed class TimeZone {
	/// <summary>
	/// The time zone's abbreviation.
	/// </summary>
	public string Abbreviation { get; init; } = null!;

	/// <summary>
	/// The time zone's IANA id.
	/// </summary>
	[JsonPropertyName("name")]
	public string IanaId { get; init; } = null!;

	/// <summary>
	/// Flag indicating if the time zone is currently in daylight savings.
	/// </summary>
	[JsonPropertyName("observes_dst")]
	public bool IsDaylightSavings { get; init; }

	[JsonInclude, JsonPropertyName("utc_offset")]
	internal double UtcOffsetRaw { get; init; }

	/// <summary>
	/// The time zone's UTC offset.
	/// </summary>
	[JsonIgnore]
	public TimeSpan UtcOffset => TimeSpan.FromHours(UtcOffsetRaw);
}