using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class GeocodeBatchRequest :
		RequestBase {
		public IList<string> Addresses { get; set; }
		public override string Body => JsonConvert.SerializeObject(Addresses);
		public override string Endpoint {
			get {
				var parameters = new HashSet<string>();

				if (Fields.Any()) {
					var fields = string.Join(",", Fields);

					parameters.Add($"field={fields}");
				}

				var query = string.Join("&", parameters);

				return $"geocode?{query}";
			}
		}
		public IList<string> Fields { get; set; } = new List<string>();
		public override HttpMethod Method => HttpMethod.Post;
	}
}