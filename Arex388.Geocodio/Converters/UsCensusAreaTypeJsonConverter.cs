using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsCensusAreaTypeJsonConverter :
	JsonConverter<UsCensusAreaType> {
	public override UsCensusAreaType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) => reader.GetString() switch {
			"metropolitan" => UsCensusAreaType.Metropolitan,
			_ => UsCensusAreaType.None
		};

	public override void Write(
		Utf8JsonWriter writer,
		UsCensusAreaType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}