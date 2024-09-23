using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class FieldsJsonConverter :
	JsonConverter<Fields> {
	public override Fields Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var hasCaCensus = element.TryGetProperty("statcan", out var caCensus);
		var hasCaFederalRiding = element.TryGetProperty("riding", out var caFederalRiding);
		var hasCaProvincialRiding = element.TryGetProperty("provincial_riding", out var caProvincialRiding);
		var hasTimezone = element.TryGetProperty("timezone", out var timezone);
		var hasUsAcs = element.TryGetProperty("acs", out var usAcs);
		var hasUsCensus = element.TryGetProperty("census", out var usCensus);
		var hasUsCongressionalDistricts = element.TryGetProperty("congrssional_districts", out var usCongressionalDistricts);
		var hasUsSchoolDistricts = element.TryGetProperty("school_districts", out var usSchoolDistricts);
		var hasUsStateDistricts = element.TryGetProperty("state_legislative_districts", out var usStateDistricts);
		var hasUsZip4 = element.TryGetProperty("zip4", out var usZip4);

		return new Fields {
			CaCensus = hasCaCensus
				? caCensus.Deserialize<CaCensus>(options)
				: null,
			CaFederalRiding = hasCaFederalRiding
				? caFederalRiding.Deserialize<CaFederalRiding>(options)
				: null,
			CaProvincialRiding = hasCaProvincialRiding
				? caProvincialRiding.Deserialize<CaProvincialRiding>(options)
				: null,
			TimeZone = hasTimezone
				? timezone.Deserialize<TimeZone>(options)
				: null,
			UsAcs = hasUsAcs
				? usAcs.Deserialize<UsAcs>(options)
				: null,
			UsCensus = hasUsCensus
				? usCensus.Deserialize<IDictionary<string, UsCensus>>(options)!.Select(
					c => c.Value).ToList()
				: [],
			UsCongressionalDistricts = hasUsCongressionalDistricts
				? usCongressionalDistricts.Deserialize<IList<UsCongressionalDistrict>>(options) ?? []
				: [],
			UsSchoolDistricts = hasUsSchoolDistricts
				? usSchoolDistricts.Deserialize<UsSchoolDistricts>(options)
				: null,
			UsStateDistricts = hasUsStateDistricts
				? usStateDistricts.Deserialize<UsStateDistricts>(options)
				: null,
			UsZip4 = hasUsZip4
				? usZip4.Deserialize<UsZip4>(options)
				: null
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		Fields value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}