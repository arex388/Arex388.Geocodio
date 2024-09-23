namespace Arex388.Geocodio;

/// <summary>
/// The result's accuracy.
/// </summary>
public enum AccuracyType {
	/// <summary>
	/// The point is a county centroid.
	/// </summary>
	County,

	/// <summary>
	/// The result is an intersection between two streets.
	/// </summary>
	Intersection,

	/// <summary>
	/// Closest city/town/place.
	/// </summary>
	NearestPlace,

	/// <summary>
	/// The exact house number was not found, so a close, neighboring house number was used instead.
	/// </summary>
	NearestRooftopMatch,

	/// <summary>
	/// Nearest match for a specific street with estimated street number.
	/// </summary>
	NearestStreet,

	/// <summary>
	/// No accuracy.
	/// </summary>
	None,

	/// <summary>
	/// The point is a city/town/place postal code centroid.
	/// </summary>
	Place,

	/// <summary>
	/// The exact point was found from address range interpolation where the range contained a single point.
	/// </summary>
	Point,

	/// <summary>
	/// The point was found by performing address range interpolation.
	/// </summary>
	RangeInterpolation,

	/// <summary>
	/// The exact point was found with rooftop level accuracy.
	/// </summary>
	Rooftop,

	/// <summary>
	/// The point is a state centroid.
	/// </summary>
	State,

	/// <summary>
	/// Teh result is a geocoded street centroid.
	/// </summary>
	StreetCenter
}