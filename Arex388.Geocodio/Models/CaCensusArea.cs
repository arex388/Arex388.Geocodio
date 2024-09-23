namespace Arex388.Geocodio;

/// <summary>
/// The CA Census area details.
/// </summary>
public sealed class CaCensusArea {
	/// <summary>
	/// The area's class.
	/// </summary>
	public int? Class { get; init; }

	/// <summary>
	/// The area's class description.
	/// </summary>
	public string? ClassDescription { get; init; }

	/// <summary>
	/// The area's code.
	/// </summary>
	public int? Code { get; init; }

	/// <summary>
	/// The area's code description.
	/// </summary>
	public string? CodeDescription { get; init; }

	/// <summary>
	/// The area's id.
	/// </summary>
	public long? Id { get; init; }

	/// <summary>
	/// The area's name.
	/// </summary>
	public string? Name { get; init; }

	/// <summary>
	/// The area's population.
	/// </summary>
	public int? Population { get; init; }

	/// <summary>
	/// The area's type.
	/// </summary>
	public string? Type { get; init; }

	/// <summary>
	/// The area's type description.
	/// </summary>
	public string? TypeDescription { get; init; }
}