using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class AccuracyTypeJsonConverter :
	JsonConverter<AccuracyType> {
	public override AccuracyType Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) => reader.GetString() switch {
			"county" => AccuracyType.County,
			"intersection" => AccuracyType.Intersection,
			"nearest_place" => AccuracyType.NearestPlace,
			"nearest_rooftop_match" => AccuracyType.NearestRooftopMatch,
			"nearest_street" => AccuracyType.NearestStreet,
			"place" => AccuracyType.Place,
			"point" => AccuracyType.Point,
			"range_interpolation" => AccuracyType.RangeInterpolation,
			"rooftop" => AccuracyType.Rooftop,
			"state" => AccuracyType.State,
			"street_center" => AccuracyType.StreetCenter,
			_ => AccuracyType.None
		};

	public override void Write(
		Utf8JsonWriter writer,
		AccuracyType value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}