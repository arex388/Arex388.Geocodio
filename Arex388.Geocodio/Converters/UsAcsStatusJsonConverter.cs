using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsAcsStatusJsonConverter :
	JsonConverter<UsAcsStatus> {
	public override UsAcsStatus? Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var hasMetadata = element.TryGetProperty("meta", out var metadata);
		var hasTotals = element.TryGetProperty("Total", out var totals);

		return new UsAcsStatus {
			Details = element.EnumerateObject().Where(
				s =>
					!s.NameEquals("meta")
					&& !s.NameEquals("Total")).Select(
				s => {
					var hasPercentage = s.Value.TryGetProperty("percentage", out var percentage);

					return new UsAcsStatusDetail {
						Count = s.Value.GetProperty("value").GetDecimal(),
						MarginOfError = s.Value.GetProperty("margin_of_error").GetDecimal(),
						Name = s.Name,
						Percentage = hasPercentage
							? percentage.GetDecimal()
							: null
					};
				}).ToList(),
			SurveyTable = hasMetadata
				? metadata.GetProperty("table_id").GetString()
				: null,
			SurveyUniverse = hasMetadata
				? metadata.GetProperty("universe").GetString()
				: null,
			TotalCount = hasTotals
				? totals.GetProperty("value").GetDecimal()
				: null,
			TotalMarginOfError = hasTotals
				? totals.GetProperty("margin_of_error").GetDecimal()
				: null
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		UsAcsStatus value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}