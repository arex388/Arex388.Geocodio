using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class TimeZone {
		/// <summary>
		/// Available as of v1.3.
		/// </summary>
		public string Abbreviation { get; set; }

		[JsonProperty("observes_dst")]
		public bool DstObserved { get; set; }

		/// <summary>
		/// As of v1.3 the Name property is the full name instead of the abbreviation.
		/// </summary>
		public string Name { get; set; }
		public string Source { get; set; }

		[JsonProperty("utc_offset")]
		public decimal UtcOffset { get; set; }
	}
}