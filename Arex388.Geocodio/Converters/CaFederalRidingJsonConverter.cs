using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class CaFederalRidingJsonConverter :
	JsonConverter<CaFederalRiding> {
	public override CaFederalRiding Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var code = element.GetProperty("code");

		return new CaFederalRiding {
			Code = code.ValueKind == JsonValueKind.Number
				? code.GetInt32()
				: int.Parse(code.GetString()!),
			NameFrench = element.GetProperty("name_french").GetString()!,
			NameEnglish = element.GetProperty("name_english").GetString()!,
			OcdId = element.GetProperty("ocd_id").GetString()!,
			Source = element.GetProperty("source").GetString()!,
			Year = element.GetProperty("year").GetInt16()
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		CaFederalRiding value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}