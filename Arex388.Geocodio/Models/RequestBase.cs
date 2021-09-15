using System.Net.Http;

namespace Arex388.Geocodio {
    /// <summary>
    /// Request base.
    /// </summary>
    public abstract class RequestBase {
        internal const string EndpointRoot = "https://api.geocod.io/v1.6";

        internal virtual string Body { get; } = null;
        internal abstract string Endpoint { get; }
        internal abstract string EndpointWithPayload { get; }
        internal abstract HttpMethod Method { get; }
        internal abstract string Payload { get; }
    }
}