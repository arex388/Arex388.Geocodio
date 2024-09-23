using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class UsAcsJsonConverter :
	JsonConverter<UsAcs> {
	public override UsAcs Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var hasDemographics = element.TryGetProperty("demographics", out var demographics);
		var hasEconomics = element.TryGetProperty("economics", out var economics);
		var hasFamilies = element.TryGetProperty("families", out var families);
		var hasHousing = element.TryGetProperty("housing", out var housing);
		var hasMetadata = element.TryGetProperty("meta", out var metadata);
		var hasSocial = element.TryGetProperty("social", out var social);

		return new UsAcs {
			Demographics = hasDemographics
				? demographics.Deserialize<UsAcsDemographics>(options)
				: null,
			Economics = hasEconomics
				? economics.Deserialize<UsAcsEconomics>(options)
				: null,
			Families = hasFamilies
				? families.Deserialize<UsAcsFamilies>(options)
				: null,
			Housing = hasHousing
				? housing.Deserialize<UsAcsHousing>(options)
				: null,
			Social = hasSocial
				? social.Deserialize<UsAcsSocial>(options)
				: null,
			Source = hasMetadata
				? metadata.GetProperty("source").GetString()
				: null,
			SurveyDuration = hasMetadata
				? byte.Parse(metadata.GetProperty("survey_duration_years").GetString()!)
				: null,
			SurveyYears = hasMetadata
				? metadata.GetProperty("survey_years").GetString()
				: null
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		UsAcs value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}