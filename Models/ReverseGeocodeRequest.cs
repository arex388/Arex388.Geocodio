using System.Collections.Generic;
using System.Linq;

namespace Arex388.Geocodio {
	public sealed class ReverseGeocodeRequest :
		RequestBase {
		public override string Endpoint {
			get {
				var parameters = new HashSet<string> {
					$"q={Location}"
				};

				if (Fields.Any()) {
					var fields = string.Join(",", Fields);

					parameters.Add($"fields={fields}");
				}

				var query = string.Join("&", parameters);

				return $"reverse?{query}";
			}
		}
		public IList<string> Fields { get; set; } = new List<string>();
		public string Location {get;set;}
	}
}