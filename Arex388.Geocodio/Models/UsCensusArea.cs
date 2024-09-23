using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Census area details.
/// </summary>
public sealed class UsCensusArea {
	/// <summary>
	/// The area's code.
	/// </summary>
	[JsonPropertyName("area_code")]
	public string Code { get; init; } = null!;

	/// <summary>
	/// The area's name.
	/// </summary>
	public string Name { get; init; } = null!;

	/// <summary>
	/// The area's type.
	/// </summary>
	public UsCensusAreaType Type { get; init; } = UsCensusAreaType.None;
}