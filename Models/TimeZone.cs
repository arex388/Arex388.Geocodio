using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class TimeZone {
		public string Abbreviation { get; set; }

		[JsonProperty("observes_dst")]
		public bool DstObserved { get; set; }

		public string Name { get; set; }
		public string Source { get; set; }

		[JsonProperty("utc_offset")]
		public decimal UtcOffset { get; set; }
	}
}