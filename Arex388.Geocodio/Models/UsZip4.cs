using System.Text.Json.Serialization;

namespace Arex388.Geocodio;

/// <summary>
/// The US Zip+4 details.
/// </summary>
public sealed class UsZip4 {
	/// <summary>
	/// The name of the building or firm.
	/// </summary>
	public string? BuildingOrFirmName { get; init; }

	/// <summary>
	/// The USPS facility type.
	/// </summary>
	[JsonPropertyName("facility_name")]
	public UsZip4FacilityType FacilityType { get; init; }

	/// <summary>
	/// The USPS government building type.
	/// </summary>
	[JsonPropertyName("government_building")]
	public UsZip4GovernmentBuildingType GovernmentBuildingType { get; init; }

	/// <summary>
	/// Flag indicating if the local post office has a city delivery route.
	/// </summary>
	[JsonPropertyName("city_delivery")]
	public bool HasCityDelivery { get; init; }

	/// <summary>
	/// Flag indicating if the query has only a single match.
	/// </summary>
	[JsonPropertyName("exact_match")]
	public bool IsExactMatch { get; init; }

	/// <summary>
	/// Flag indicating if the address is a valid delivery point.
	/// </summary>
	[JsonPropertyName("valid_delivery_area")]
	public bool IsValidForDeliveries { get; init; }

	/// <summary>
	/// The Zip+4 code(s).
	/// </summary>
	public IList<string> Plus4 { get; init; } = [];

	/// <summary>
	/// The Zip+4 type.
	/// </summary>
	public UsZip4RecordType RecordType { get; init; }

	/// <summary>
	/// The carrier route.
	/// </summary>
	[JsonPropertyName("carrier_route")]
	public UsZip4Route Route { get; init; } = null!;

	/// <summary>
	/// The full ZIP+4 code(s).
	/// </summary>
	public IList<string> Zip9 { get; init; } = [];
}