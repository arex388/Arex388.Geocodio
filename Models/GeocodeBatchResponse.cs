using System.Collections.Generic;
using System.Linq;

namespace Arex388.Geocodio {
	public sealed class GeocodeBatchResponse :
		ResponseBase {
		public IList<GeocodeBatchResult> Results { get; set; }
		public override bool Success => Results?.Any() ?? false;
	}
}