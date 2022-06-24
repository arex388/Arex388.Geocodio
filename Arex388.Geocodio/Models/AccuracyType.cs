namespace Arex388.Geocodio;

public static class AccuracyType {
    /// <summary>
    /// The point is a county centroid.
    /// </summary>
    public static readonly string County = "county";

    /// <summary>
    /// The result is an intersection between two streets.
    /// </summary>
    public static readonly string Intersection = "intersection";

    /// <summary>
    /// Closest city/town/place.
    /// </summary>
    public static readonly string NearestPlace = "nearest_place";

    /// <summary>
    /// The exact house number was not found, so a close, neighboring house number was used instead.
    /// </summary>
    public static readonly string NearestRooftopMatch = "nearest_rooftop_match";

    /// <summary>
    /// Nearest match for a specific street with estimated street number.
    /// </summary>
    public static readonly string NearestStreet = "nearest_street";

    /// <summary>
    /// The point is a city/town/place zip code centroid.
    /// </summary>
    public static readonly string Place = "place";

    /// <summary>
    /// The exact point was found from address range interpolation where the range contained a single point.
    /// </summary>
    public static readonly string Point = "point";

    /// <summary>
    /// The point was found by performing address range interpolation.
    /// </summary>
    public static readonly string RangeInterpolation = "range_interpolation";

    /// <summary>
    /// The exact point was found with rooftop level accuracy.
    /// </summary>
    public static readonly string Rooftop = "rooftop";

    /// <summary>
    /// The point is a state centroid.
    /// </summary>
    public static readonly string State = "state";

    /// <summary>
    /// The result is a geocoded street centroid.
    /// </summary>
    public static readonly string Street = "street_center";
}