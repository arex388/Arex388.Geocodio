using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Arex388.Geocodio; 

public sealed class ReverseGeocodeRequest :
    RequestBase {
    internal override string Endpoint => $"{EndpointRoot}/reverse";
    internal override string EndpointWithPayload => $"{Endpoint}?{Payload}";
    internal override HttpMethod Method => HttpMethod.Get;
    internal override string Payload {
        get {
            var parameters = new HashSet<string> {
                $"q={Coordinates}"
            };

            if (Fields.Any()) {
                var fields = Fields.StringJoin(",");

                parameters.Add($"fields={fields}");
            }

            return parameters.StringJoin("&");
        }
    }

    //  ========================================================================

    public string Coordinates { get; set; }
    public IEnumerable<string> Fields { get; set; } = Enumerable.Empty<string>();
}