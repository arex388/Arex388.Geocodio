using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class CongressLegislatorContact {
		public string Address { get; set; }

		[JsonProperty("contact_form")]
		public object ContactForm { get; set; }

		public string Phone { get; set; }
		public string Url { get; set; }
	}
}