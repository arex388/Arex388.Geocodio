using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsZip4RecordTypeJsonConverter :
	JsonConverter<UsZip4RecordType> {
	public override UsZip4RecordType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var recordType = element.GetProperty("code").GetString();

		return recordType switch {
			"F" => UsZip4RecordType.Firm,
			"G" => UsZip4RecordType.GeneralDelivery,
			"H" => UsZip4RecordType.HighRise,
			"P" => UsZip4RecordType.PoBox,
			"R" => UsZip4RecordType.RuralRouteOrContract,
			"S" => UsZip4RecordType.Street,
			_ => UsZip4RecordType.Unknown
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		UsZip4RecordType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}