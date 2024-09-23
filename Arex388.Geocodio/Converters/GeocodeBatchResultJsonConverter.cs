using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class GeocodeBatchResultJsonConverter :
	JsonConverter<GeocodeBatchResult> {
	public override GeocodeBatchResult Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;

		return new GeocodeBatchResult {
			Address = element.GetProperty("query").GetString()!,
			Results = element.GetProperty("response").GetProperty("results").Deserialize<IList<GeocodeResult>>(options)!
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		GeocodeBatchResult value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}