namespace Arex388.Geocodio;

/// <summary>
/// The request's base details.
/// </summary>
public abstract class RequestBase {
	internal abstract string Endpoint { get; }

	/// <summary>
	/// Additional fields to append to the response.
	/// </summary>
	public IList<FieldType> Fields { get; init; } = [];

	/// <summary>
	/// The number of results to return. Unlimited by default.
	/// </summary>
	public int? Take { get; init; }
}