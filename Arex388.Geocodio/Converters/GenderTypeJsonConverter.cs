using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class GenderTypeJsonConverter :
	JsonConverter<GenderType> {
	public override GenderType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) => reader.GetString() switch {
			"F" => GenderType.Female,
			"M" => GenderType.Male,
			_ => GenderType.Other
		};

	public override void Write(
		Utf8JsonWriter writer,
		GenderType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}