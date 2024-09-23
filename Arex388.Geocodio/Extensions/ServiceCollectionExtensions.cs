using Arex388.Geocodio;
using FluentValidation;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// <see cref="IServiceCollection"/> extensions.
/// </summary>
public static class ServiceCollectionExtensions {
	/// <summary>
	/// Add the Geocod.io API client factory for interacting with multiple accounts.
	/// </summary>
	/// <param name="services">The services collection.</param>
	/// <returns>The services collection.</returns>
	public static IServiceCollection AddGeocodio(
		this IServiceCollection services) => services.AddHttpClient()
													 .AddMemoryCache()
													 .AddValidatorsFromAssemblyContaining<IGeocodioClient>(includeInternalTypes: true, lifetime: ServiceLifetime.Singleton)
													 .AddSingleton<IGeocodioClientFactory, GeocodioClientFactory>();

	/// <summary>
	/// Add the Geocod.io API client for interacting with a single account.
	/// </summary>
	/// <param name="services">The services collection.</param>
	/// <param name="options">The client's configuration options.</param>
	/// <returns>The services collection.</returns>
	public static IServiceCollection AddGeocodio(
		this IServiceCollection services,
		GeocodioClientOptions options) {
		services.AddHttpClient<IGeocodioClient>(
			hc => {
				hc.BaseAddress = HttpClientHelper.BaseAddress;
			});

		return services.AddValidatorsFromAssemblyContaining<IGeocodioClient>(includeInternalTypes: true, lifetime: ServiceLifetime.Singleton)
					   .AddSingleton(options)
					   .AddSingleton<IGeocodioClient>(
						   sp => new GeocodioClient(sp));
	}
}