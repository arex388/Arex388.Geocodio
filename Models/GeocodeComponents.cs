using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class GeocodeComponents {
		public string City { get; set; }
		public string Country { get; set; }
		public string County { get; set; }

		[JsonProperty("formatted_street")]
		public string FormattedStreet { get; set; }

		public string Number { get; set; }

		[JsonProperty("zip")]
		public string PostalCode { get; set; }

		public string PreDirectional { get; set; }
		public string State { get; set; }
		public string Street { get; set; }
		public string Suffix { get; set; }
	}
}