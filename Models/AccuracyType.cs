namespace Arex388.Geocodio {
	public static class AccuracyType {
		/// <summary>
		/// Closest city/town/place
		/// </summary>
		public static readonly string NearestPlace = "nearest_place";

		/// <summary>
		/// Nearest match for a specific street with estimated street number
		/// </summary>
		public static readonly string NearestStreet = "nearest_street";

		/// <summary>
		/// The point is a city/town/place
		/// </summary>
		public static readonly string Place = "place";

		/// <summary>
		/// We found the exact point from address range interpolation where the range contained a single point
		/// </summary>
		public static readonly string Point = "point";

		/// <summary>
		/// We found the exact point by performing address range interpolation
		/// </summary>
		public static readonly string RangeInterpolation = "range_interpolation";

		/// <summary>
		/// We found the exact point with rooftop level accuracy
		/// </summary>
		public static readonly string Rooftop = "rooftop";

		/// <summary>
		/// The point is a state
		/// </summary>
		public static readonly string State = "state";

		/// <summary>
		/// The result is a geocoded street centroid
		/// </summary>
		public static readonly string StreetCenter = "street_center";
	}
}