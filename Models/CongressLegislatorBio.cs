using System;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class CongressLegislatorBio {
		public DateTime Birthday { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		public string Gender { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		public string Party { get; set; }
	}
}