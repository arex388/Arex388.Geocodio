using System.Collections.Generic;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class Fields {
		public Acs Acs { get; set; }
		public Census Census { get; set; }

		[JsonProperty("congressional_districts")]
		public IList<CongressionalDistrict> CongressionalDistricts { get; set; }

		[JsonProperty("school_districts")]
		public SchoolDistricts SchoolDistricts { get; set; }

		[JsonProperty("state_legislative_districts")]
		public StateDistricts StateDistricts { get; set; }

		public TimeZone TimeZone { get; set; }
	}
}