using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsZip4FacilityTypeJsonConverter :
	JsonConverter<UsZip4FacilityType> {
	public override UsZip4FacilityType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var facilityType = element.GetProperty("code").GetString();

		return facilityType switch {
			"B" => UsZip4FacilityType.Branch,
			"C" => UsZip4FacilityType.CommunityPostOffice,
			"N" => UsZip4FacilityType.NonPostOffice,
			"P" => UsZip4FacilityType.PostOffice,
			"S" => UsZip4FacilityType.Station,
			"U" => UsZip4FacilityType.Urbanization,
			_ => UsZip4FacilityType.Unknown
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		UsZip4FacilityType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}