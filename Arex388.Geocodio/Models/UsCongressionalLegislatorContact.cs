using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Congressional legislator's contact details.
/// </summary>
public sealed class UsCongressionalLegislatorContact {
	/// <summary>
	/// The legislator's office address.
	/// </summary>
	public string Address { get; init; } = null!;

	/// <summary>
	/// The legislator's contact page.
	/// </summary>
	[JsonPropertyName("contact_form")]
	public Uri? ContactUrl { get; init; }

	/// <summary>
	/// The legislator's page.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri OfficialUrl { get; init; } = null!;

	/// <summary>
	/// The legislator's office phone.
	/// </summary>
	public string Phone { get; init; } = null!;
}