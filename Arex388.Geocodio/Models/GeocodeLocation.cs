using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class GeocodeLocation {
		[JsonProperty("lat")]
		public decimal Latitude { get; set; }

		[JsonProperty("lng")]
		public decimal Longitude { get; set; }
	}
}