using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsCongressionalLegislatorTypeJsonConverter :
	JsonConverter<UsCongressionalLegislatorType> {
	public override UsCongressionalLegislatorType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) => reader.GetString() switch {
			"representative" => UsCongressionalLegislatorType.Representative,
			"senator" => UsCongressionalLegislatorType.Senator,
			_ => UsCongressionalLegislatorType.Unknown
		};

	public override void Write(
		Utf8JsonWriter writer,
		UsCongressionalLegislatorType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}