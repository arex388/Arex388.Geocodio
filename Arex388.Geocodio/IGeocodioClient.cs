// ReSharper disable UnusedMemberInSuper.Global

namespace Arex388.Geocodio;

/// <summary>
/// Geocod.io API client.
/// </summary>
public interface IGeocodioClient {
	/// <summary>
	/// Geocode an address.
	/// </summary>
	/// <param name="address">The address to geocode.</param>
	/// <param name="mostAccurate">Flag indicating if only the most accurate result should be returned (limit = 1). True by default.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="Geocode.Response"/> response.</returns>
	Task<Geocode.Response> GeocodeAsync(
		string address,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Geocode an address.
	/// </summary>
	/// <param name="request">The <see cref="Geocode.Request"/> request.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="Geocode.Response"/> response.</returns>
	Task<Geocode.Response> GeocodeAsync(
		Geocode.Request request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Geocode multiple addresses.
	/// </summary>
	/// <param name="addresses">The addresses to geocode.</param>
	/// <param name="mostAccurate">Flag indicating if only the most accurate result should be returned (limit = 1). True by default.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="GeocodeMany.Response"/> response.</returns>
	Task<GeocodeMany.Response> GeocodeManyAsync(
		IList<string> addresses,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Geocode multiple addresses.
	/// </summary>
	/// <param name="request">The <see cref="GeocodeMany.Request"/> request.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="GeocodeMany.Response"/> response.</returns>
	Task<GeocodeMany.Response> GeocodeManyAsync(
		GeocodeMany.Request request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reverse geocode a point.
	/// </summary>
	/// <param name="latitude">The point's latitude.</param>
	/// <param name="mostAccurate">Flag indicating if only the most accurate result should be returned (limit = 1). True by default.</param>
	/// <param name="longitude">The point's longitude.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="ReverseGeocode.Response"/> response.</returns>
	Task<ReverseGeocode.Response> ReverseGeocodeAsync(
		decimal latitude,
		decimal longitude,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reverse geocode a point.
	/// </summary>
	/// <param name="point">The point to reverse geocode. The string should be formatted as "{latitude},{longitude}".</param>
	/// <param name="mostAccurate">Flag indicating if only the most accurate result should be returned (limit = 1). True by default.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="ReverseGeocode.Response"/> response.</returns>
	Task<ReverseGeocode.Response> ReverseGeocodeAsync(
		string point,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reverse geocode a point.
	/// </summary>
	/// <param name="request">The <see cref="ReverseGeocode.Request"/> request.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="ReverseGeocode.Response"/> response.</returns>
	Task<ReverseGeocode.Response> ReverseGeocodeAsync(
		ReverseGeocode.Request request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reverse geocode multiple points.
	/// </summary>
	/// <param name="points">The points to geocode.</param>
	/// <param name="mostAccurate">Flag indicating if only the most accurate result should be returned (limit = 1). True by default.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="ReverseGeocodeMany.Response"/> response.</returns>
	Task<ReverseGeocodeMany.Response> ReverseGeocodeManyAsync(
		IList<string> points,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reverse geocode multiple points.
	/// </summary>
	/// <param name="request">The <see cref="ReverseGeocodeMany.Request"/> request.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The <see cref="ReverseGeocodeMany.Response"/> response.</returns>
	Task<ReverseGeocodeMany.Response> ReverseGeocodeManyAsync(
		ReverseGeocodeMany.Request request,
		CancellationToken cancellationToken = default);
}