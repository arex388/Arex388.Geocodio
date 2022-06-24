using System.Collections.Generic;

namespace Arex388.Geocodio; 

public sealed class GeocodeBatchResponse :
    ResponseBase {
    public IList<GeocodeBatchResult> Results { get; set; }
}