namespace Arex388.Geocodio;

internal static class RequestBaseExtensions {
	public static string GetEndpoint(
		this RequestBase request,
		GeocodioClientOptions options) => $"{request.Endpoint}&api_key={options.Key}";
}