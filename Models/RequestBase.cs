using System.Net.Http;

namespace Arex388.Geocodio {
	public abstract class RequestBase {
		public virtual string Body { get; }
		public abstract string Endpoint { get; }
		public virtual HttpMethod Method { get; } = HttpMethod.Get;
	}
}