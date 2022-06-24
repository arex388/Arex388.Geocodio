using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Arex388.Geocodio; 

public sealed class ReverseGeocodeBatchRequest :
    RequestBase {
    internal override string Body => JsonConvert.SerializeObject(Coordinates);
    internal override string Endpoint => $"{EndpointRoot}/reverse";
    internal override string EndpointWithPayload => $"{Endpoint}?{Payload}";
    internal override HttpMethod Method => HttpMethod.Post;
    internal override string Payload {
        get {
            var parameters = new HashSet<string>();

            if (Fields.Any()) {
                var fields = Fields.StringJoin(",");

                parameters.Add($"fields={fields}");
            }

            return parameters.StringJoin("&");
        }
    }

    //  ========================================================================

    public IEnumerable<string> Coordinates { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> Fields { get; set; } = Enumerable.Empty<string>();
}