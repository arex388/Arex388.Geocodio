using System.Collections.Generic;
using System.Linq;

namespace Arex388.Geocodio {
	public sealed class ReverseGeocodeRequest :
		RequestBase {
		public override string Endpoint {
			get {
				var parameters = new HashSet<string> {
					$"q={Latitude},{Longitude}"
				};

				if (Fields.Any()) {
					var fields = string.Join(",", Fields);

					parameters.Add($"fields={fields}");
				}

				var query = string.Join("&", parameters);

				return $"{EndpointRoot}/reverse?{query}";
			}
		}
		public IEnumerable<string> Fields { get; set; } = Enumerable.Empty<string>();
		public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }
	}
}