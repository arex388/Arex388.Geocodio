namespace Arex388.Geocodio.Models {
	public static class AccuracyType {
		/// <summary>
		/// Closest city/town/place
		/// </summary>
		public const string NearestPlace = "nearest_place";

		/// <summary>
		/// Nearest match for a specific street with estimated street number
		/// </summary>
		public const string NearestStreet = "nearest_street";

		/// <summary>
		/// The point is a city/town/place
		/// </summary>
		public const string Place = "place";

		/// <summary>
		/// We found the exact point from address range interpolation where the range contained a single point
		/// </summary>
		public const string Point = "point";

		/// <summary>
		/// We found the exact point by performing address range interpolation
		/// </summary>
		public const string RangeInterpolation = "range_interpolation";

		/// <summary>
		/// We found the exact point with rooftop level accuracy
		/// </summary>
		public const string Rooftop = "rooftop";

		/// <summary>
		/// The point is a state
		/// </summary>
		public const string State = "state";

		/// <summary>
		/// The result is a geocoded street centroid
		/// </summary>
		public const string StreetCenter = "street_center";
	}
}