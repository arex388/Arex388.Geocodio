using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arex388.Geocodio {
	public sealed class GeocodeRequest :
		RequestBase {
		public string Address { get; set; }
		public override string Endpoint {
			get {
				var parameters = new HashSet<string> {
					$"q={HttpUtility.UrlEncode(Address)}"
				};

				if (Fields.Any()) {
					var fields = string.Join(",", Fields);

					parameters.Add($"fields={fields}");
				}

				var query = string.Join("&", parameters);

				return $"{EndpointRoot}/geocode?{query}";
			}
		}
		public IEnumerable<string> Fields { get; set; } = Enumerable.Empty<string>();
	}
}