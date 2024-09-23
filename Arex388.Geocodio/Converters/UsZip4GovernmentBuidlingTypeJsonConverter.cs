using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsZip4GovernmentBuidlingTypeJsonConverter :
	JsonConverter<UsZip4GovernmentBuildingType> {
	public override UsZip4GovernmentBuildingType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) => reader.GetString() switch {
			"A" => UsZip4GovernmentBuildingType.CityGovernmentBuilding,
			"B" => UsZip4GovernmentBuildingType.FederalGovernmentBuilding,
			"C" => UsZip4GovernmentBuildingType.StateGovernmentBuilding,
			"D" => UsZip4GovernmentBuildingType.FirmOnly,
			"E" => UsZip4GovernmentBuildingType.CityGovernmentBuildingAndFirmOnly,
			"F" => UsZip4GovernmentBuildingType.FederalGovernmentBuildingAndFirmOnly,
			"G" => UsZip4GovernmentBuildingType.StateGovernmentBuildingAndFirmOnly,
			_ => UsZip4GovernmentBuildingType.Unknown
		};

	public override void Write(
		Utf8JsonWriter writer,
		UsZip4GovernmentBuildingType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}