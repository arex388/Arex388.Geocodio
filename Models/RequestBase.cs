using System.Net.Http;

namespace Arex388.Geocodio {
	public abstract class RequestBase {
		protected string EndpointRoot = "https://api.geocod.io/v1.3";

		public virtual string Body { get; }
		public abstract string Endpoint { get; }
		public virtual HttpMethod Method { get; } = HttpMethod.Get;
	}
}