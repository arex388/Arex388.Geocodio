using System.Collections.Generic;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class Fields {
		public Acs Acs { get; set; }
		public Census Census { get; set; }

		[JsonProperty("congressional_districts")]
		public IList<CongressionalDistrict> CongressionalDistricts { get; set; }

		/// <summary>
		/// congressional_district was renamed to congressional_districts (plural)
		/// and changed to a collection in v1.1.
		/// </summary>
		[JsonProperty("congressional_district")]
		private CongressionalDistrict CongressionalDistrict {
			set => CongressionalDistricts = new List<CongressionalDistrict> {
				value
			};
		}

		[JsonProperty("school_districts")]
		public SchoolDistricts SchoolDistricts { get; set; }

		[JsonProperty("state_legislative_districts")]
		public StateDistricts StateDistricts { get; set; }

		public TimeZone TimeZone { get; set; }
	}
}