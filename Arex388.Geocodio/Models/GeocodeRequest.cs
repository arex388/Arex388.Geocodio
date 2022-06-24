using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace Arex388.Geocodio; 

public sealed class GeocodeRequest :
    RequestBase {
    internal override string Endpoint => $"{EndpointRoot}/geocode";
    internal override string EndpointWithPayload => $"{Endpoint}?{Payload}";
    internal override HttpMethod Method => HttpMethod.Get;
    internal override string Payload {
        get {
            var parameters = new HashSet<string> {
                $"q={WebUtility.UrlEncode(Address)}"
            };

            if (Fields.Any()) {
                var fields = Fields.StringJoin(",");

                parameters.Add($"fields={fields}");
            }

            return parameters.StringJoin("&");
        }
    }

    //  ========================================================================

    public string Address { get; set; }
    public IEnumerable<string> Fields { get; set; } = Enumerable.Empty<string>();
}