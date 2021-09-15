using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Arex388.Geocodio {
	public sealed class TimeZone {
		public string Abbreviation { get; set; }

		[JsonProperty("observes_dst")]
		public bool DstObserved { get; set; }

		public string Name { get; set; }
		public string Source { get; set; }

		[JsonProperty("utc_offset")]
		public decimal UtcOffset { get; set; }

		public string UtcOffsetNormalized => NormalizeUtcOffset(UtcOffset);

		private static readonly IDictionary<int, string> Signs = new Dictionary<int, string> {
			{ -1, "-" },
			{ 0, "+" },
			{ 1, "+" }
		};

		private static string NormalizeUtcOffset(
			decimal utcOffset) {
			var utcOffsetAbs = Math.Abs(utcOffset);
			var utcOffsetSign = Math.Sign(utcOffset);

			var remainder = utcOffsetAbs % 1;
			var sign = Signs[utcOffsetSign];

			var hours = (int)(utcOffsetAbs - remainder);
			var minutes = (int)(remainder * 60);

			return $"{sign}{hours:D2}:{minutes:D2}";
		}
	}
}