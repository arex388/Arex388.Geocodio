using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Arex388.Geocodio {
    /// <summary>
    /// Geocod.io API client extensions.
    /// </summary>
    public static class GeocodioClientExtensions {
        /// <summary>
        /// Get the most accurate latitude and longitude point of an address.
        /// </summary>
        /// <param name="geocodio">The Geocodi.io API client instance.</param>
        /// <param name="address">The address to geocode.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Tupple of (latitude, longitude) as decimals.</returns>
        public static async Task<(
            decimal latitude,
            decimal longitude
        )?> GetPointAsync(
            this IGeocodioClient geocodio,
            string address,
            CancellationToken cancellationToken) {
            if (!address.HasValue()) {
                return null;
            }

            var response = await geocodio.GeocodeAsync(address, Enumerable.Empty<string>(), cancellationToken).ConfigureAwait(false);

            if (response.ResponseStatus != ResponseStatus.Success) {
                return null;
            }

            var result = response.Results.OrderByDescending(
                _ => _.Accuracy).FirstOrDefault();

            if (result is null) {
                return null;
            }

            return (
                result.Location.Latitude,
                result.Location.Longitude
            );
        }
    }
}