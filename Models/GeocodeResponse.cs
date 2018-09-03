using System.Collections.Generic;
using System.Linq;

namespace Arex388.Geocodio {
	public sealed class GeocodeResponse :
		ResponseBase {
		public IEnumerable<GeocodeResult> Results { get; set; }
		public override bool Success => Results?.Any() ?? false;
	}
}