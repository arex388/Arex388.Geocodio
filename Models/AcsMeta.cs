using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsMeta {
		public string Source { get; set; }

		[JsonProperty("survey_years")]
		public string SurveyYears { get; set; }

		[JsonProperty("survey_duration_years")]
		public string SurveyDurationYears { get; set; }
	}
}