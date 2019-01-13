using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class ReverseGeocodeBatchRequest :
		RequestBase {
		public override string Body => JsonConvert.SerializeObject(Coordinates);
		public IList<string> Coordinates { get; set; }
		public override string Endpoint {
			get {
				var parameters = new HashSet<string>();

				if (Fields.Any()) {
					var fields = string.Join(",", Fields);

					parameters.Add($"fields={fields}");
				}

				var query = string.Join("&", parameters);

				return $"reverse?{query}";
			}
		}
		public IList<string> Fields { get; set; } = new List<string>();
		public override HttpMethod Method => HttpMethod.Post;
	}
}