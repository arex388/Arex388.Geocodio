using System.Collections.Generic;

namespace Arex388.Geocodio; 

public sealed class GeocodeResponse :
    ResponseBase {
    public IList<GeocodeResult> Results { get; set; }
}