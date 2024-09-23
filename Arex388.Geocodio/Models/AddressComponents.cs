using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The components of the address.
/// </summary>
public sealed class AddressComponents {
	/// <summary>
	/// The city.
	/// </summary>
	public string City { get; init; } = null!;

	/// <summary>
	/// The county.
	/// </summary>
	public string County { get; init; } = null!;

	/// <summary>
	/// The country.
	/// </summary>
	public string Country { get; init; } = null!;

	/// <summary>
	/// The property number.
	/// </summary>
	public string Number { get; init; } = null!;

	/// <summary>
	/// The postal code.
	/// </summary>
	[JsonPropertyName("zip")]
	public string PostalCode { get; init; } = null!;

	/// <summary>
	/// The directional after the street.
	/// </summary>
	public string? Postdirectional { get; init; }

	/// <summary>
	/// The directional before the street.
	/// </summary>
	public string? Predirectional { get; init; }

	/// <summary>
	/// The abbreviated street prefix.
	/// </summary>
	public string? Prefix { get; init; }

	/// <summary>
	/// The state.
	/// </summary>
	public string State { get; init; } = null!;

	/// <summary>
	/// The street.
	/// </summary>
	public string Street { get; init; } = null!;

	/// <summary>
	/// The abbreviated street suffix.
	/// </summary>
	public string? Suffix { get; init; }
}