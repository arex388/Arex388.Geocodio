using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Arex388.Geocodio;

/// <summary>
/// Geocod.io API client.
/// </summary>
public interface IGeocodioClient {
    /// <summary>
    /// Geocode an address.
    /// </summary>
    /// <param name="address">The address to geocode.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeResponse</returns>
    Task<GeocodeResponse> GeocodeAsync(
        string address,
        CancellationToken cancellationToken);

    /// <summary>
    /// Geocode an address.
    /// </summary>
    /// <param name="address">The address to geocode.</param>
    /// <param name="fields">Optional fields to expand in the response.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeResponse</returns>
    Task<GeocodeResponse> GeocodeAsync(
        string address,
        IEnumerable<string> fields,
        CancellationToken cancellationToken);

    /// <summary>
    /// Geocode an address.
    /// </summary>
    /// <param name="request">A GeocodeRequest instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeResponse</returns>
    Task<GeocodeResponse> GeocodeAsync(
        GeocodeRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Geocode a batch of addresses.
    /// </summary>
    /// <param name="addresses">The addresses to geocode.</param>
    /// <param name="cancellationToken">The cancellation token/</param>
    /// <returns>GeocodeBatchResponse</returns>
    Task<GeocodeBatchResponse> GeocodeBatchAsync(
        IEnumerable<string> addresses,
        CancellationToken cancellationToken);

    /// <summary>
    /// Geocode a batch of addresses.
    /// </summary>
    /// <param name="addresses">The addresses to geocode.</param>
    /// <param name="fields">Optional fields to expand in the response.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeBatchResponse</returns>
    Task<GeocodeBatchResponse> GeocodeBatchAsync(
        IEnumerable<string> addresses,
        IEnumerable<string> fields,
        CancellationToken cancellationToken);

    /// <summary>
    /// Geocode a batch of addresses.
    /// </summary>
    /// <param name="request">A GeocodeRequest instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeBatchResponse</returns>
    Task<GeocodeBatchResponse> GeocodeBatchAsync(
        GeocodeBatchRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Reverse geocode a coordinate.
    /// </summary>
    /// <param name="coordinates">The coordinate to reverse geocode.</param>
    /// <param name="cancellationToken">The cancellation token/</param>
    /// <returns>GeocodeResponse</returns>
    Task<GeocodeResponse> ReverseGeocodeAsync(
        string coordinates,
        CancellationToken cancellationToken);

    /// <summary>
    /// Reverse geocode a coordinate.
    /// </summary>
    /// <param name="coordinates">The coordinate to reverse geocode.</param>
    /// <param name="fields">Optional fields to expand in the response.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeResponse</returns>
    Task<GeocodeResponse> ReverseGeocodeAsync(
        string coordinates,
        IEnumerable<string> fields,
        CancellationToken cancellationToken);

    /// <summary>
    /// Reverse geocode a coordinate.
    /// </summary>
    /// <param name="request">A GeocodeRequest instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeResponse</returns>
    Task<GeocodeResponse> ReverseGeocodeAsync(
        ReverseGeocodeRequest request,
        CancellationToken cancellationToken);

    /// <summary>
    /// Reverse geocode a batch of coordinates.
    /// </summary>
    /// <param name="coordiantes">The coordinates to reverse geocode.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeBatchResponse</returns>
    Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
        IEnumerable<string> coordiantes,
        CancellationToken cancellationToken);

    /// <summary>
    /// Reverse geocode a batch of coordinates.
    /// </summary>
    /// <param name="coordinates">The coordinates to reverse geocode.</param>
    /// <param name="fields">Optional fields to expand in the response.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeBatchResponse</returns>
    Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
        IEnumerable<string> coordinates,
        IEnumerable<string> fields,
        CancellationToken cancellationToken);

    /// <summary>
    /// Reverse geocode a batch of coordinates.
    /// </summary>
    /// <param name="request">A GeocodeRequest instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>GeocodeBatchResponse</returns>
    Task<GeocodeBatchResponse> ReverseGeocodeBatchAsync(
        ReverseGeocodeBatchRequest request,
        CancellationToken cancellationToken);
}