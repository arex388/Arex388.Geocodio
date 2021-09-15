using Arex388.Geocodio;
using System;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection {
    public static class ServiceCollectionExtensions {
        /// <summary>
        /// Add Geocod.io API client as a singleton. TEST
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="key">Your Geocod.io API key.</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddGeocodio(
            this IServiceCollection services,
            string key) {
            if (key is null) {
                throw new ArgumentNullException(nameof(key));
            }

            services.AddHttpClient<GeocodioClient>(nameof(GeocodioClient));

            return services.AddSingleton<IGeocodioClient>(
                _ => {
                    var httpClientFactory = _.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient(nameof(GeocodioClient));

                    return new GeocodioClient(httpClient, key);
                });
        }
    }
}