using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Congressional legislator's biographical details.
/// </summary>
public sealed class UsCongressionalLegislatorBio {
	private string? _name;

	/// <summary>
	/// The legislator's birth day.
	/// </summary>
	[JsonPropertyName("birthday")]
	public DateTime DateOfBirth { get; init; }

	[JsonInclude]
	internal string FirstName { get; init; } = null!;

	/// <summary>
	/// The legislator's gender.
	/// </summary>
	public GenderType Gender { get; init; }

	[JsonInclude]
	internal string LastName { get; init; } = null!;

	/// <summary>
	/// The legislator's name.
	/// </summary>
	public string Name => _name ??= $"{FirstName} {LastName}";

	/// <summary>
	/// The legislator's political party.
	/// </summary>
	public string Party { get; init; } = null!;
}