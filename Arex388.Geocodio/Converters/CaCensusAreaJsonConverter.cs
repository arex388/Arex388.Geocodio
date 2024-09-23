using System.Text.Json;
using System.Text.Json.Serialization;

namespace Arex388.Geocodio.Converters;

internal sealed class CaCensusAreaJsonConverter :
	JsonConverter<CaCensusArea> {
	public override CaCensusArea Read(
		ref Utf8JsonReader reader,
		Type typeToConvert,
		JsonSerializerOptions options) {
		var element = JsonDocument.ParseValue(ref reader).RootElement;
		var hasClass = element.TryGetProperty("class", out var @class);
		var hasCode = element.TryGetProperty("code", out var code);
		var hasId = element.TryGetProperty("id", out var id);
		var hasName = element.TryGetProperty("name", out var name);
		var hasPopulation = element.TryGetProperty("population", out var population);
		var hasType = element.TryGetProperty("type", out var type);

		return new CaCensusArea {
			Class = hasClass
				? int.Parse(@class.GetString()!)
				: null,
			ClassDescription = hasClass
				? element.GetProperty("class_description").GetString()
				: null,
			Code = hasCode
				? int.Parse(code.GetString()!)
				: null,
			CodeDescription = hasCode
				? element.GetProperty("code_description").GetString()
				: null,
			Id = hasId
				? long.Parse(id.GetString()!)
				: null,
			Name = hasName
				? name.GetString()
				: null,
			Population = hasPopulation
				? int.Parse(population.GetString()!)
				: null,
			Type = hasType
				? type.GetString()
				: null,
			TypeDescription = hasType
				? element.GetProperty("type_description").GetString()
				: null
		};
	}

	public override void Write(
		Utf8JsonWriter writer,
		CaCensusArea value,
		JsonSerializerOptions options) => throw new NotImplementedException();
}