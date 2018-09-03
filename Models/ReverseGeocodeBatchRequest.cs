using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class ReverseGeocodeBatchRequest :
		RequestBase {
		public override string Body => JsonConvert.SerializeObject(Coordinates);
		public IEnumerable<string> Coordinates { get; set; }
		public override string Endpoint {
			get {
				var parameters = new HashSet<string>();

				if (Fields.Any()) {
					var fields = string.Join(",", Fields);

					parameters.Add($"fields={fields}");
				}

				var query = string.Join("&", parameters);

				return $"{EndpointRoot}/reverse?{query}";
			}
		}
		public IEnumerable<string> Fields { get; set; } = Enumerable.Empty<string>();
		public override HttpMethod Method => HttpMethod.Post;
	}
}