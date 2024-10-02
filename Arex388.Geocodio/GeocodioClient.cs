using Arex388.Geocodio.Converters;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;
using System.Text.Json;

namespace Arex388.Geocodio;

internal sealed class GeocodioClient(
	IServiceProvider services,
	HttpClient? httpClient = null,
	GeocodioClientOptions? options = null) :
	IGeocodioClient {
	private static readonly JsonSerializerOptions _jsonSerializerOptions = new() {
		Converters = {
			new AccuracyTypeJsonConverter(),
			new CaCensusAreaJsonConverter(),
			new CaFederalRidingJsonConverter(),
			new FieldsJsonConverter(),
			new GenderTypeJsonConverter(),
			new GeocodeBatchResultJsonConverter(),
			new UsAcsJsonConverter(),
			new UsAcsStatusJsonConverter(),
			new UsCensusAreaTypeJsonConverter(),
			new UsCongressionalLegislatorTypeJsonConverter(),
			new UsZip4FacilityTypeJsonConverter(),
			new UsZip4GovernmentBuidlingTypeJsonConverter(),
			new UsZip4RecordTypeJsonConverter()
		},
		PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
	};

	private readonly IValidator<GeocodeMany.Request> _geocodeBatchValidator = services.GetRequiredService<IValidator<GeocodeMany.Request>>();
	private readonly IValidator<Geocode.Request> _geocodeValidator = services.GetRequiredService<IValidator<Geocode.Request>>();
	private readonly HttpClient _httpClient = httpClient ?? services.GetRequiredService<IHttpClientFactory>().CreateClient(nameof(IGeocodioClient));
	private readonly GeocodioClientOptions _options = options ?? services.GetRequiredService<GeocodioClientOptions>();
	private readonly IValidator<ReverseGeocodeMany.Request> _reverseGeocodeBatchValidator = services.GetRequiredService<IValidator<ReverseGeocodeMany.Request>>();
	private readonly IValidator<ReverseGeocode.Request> _reverseGeocodeValidator = services.GetRequiredService<IValidator<ReverseGeocode.Request>>();

	public Guid Id { get; } = Guid.NewGuid();

	public Task<Geocode.Response> GeocodeAsync(
		string address,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default) => GeocodeAsync(new Geocode.Request {
			Address = address,
			Take = mostAccurate
				? 1
				: null
		}, cancellationToken);

	public async Task<Geocode.Response> GeocodeAsync(
		Geocode.Request request,
		CancellationToken cancellationToken = default) {
		if (cancellationToken.IsSupportedAndCancelled()) {
			return Geocode.Response.Cancelled;
		}

		// ReSharper disable once MethodHasAsyncOverloadWithCancellation
		var validationResult = _geocodeValidator.Validate(request);

		if (!validationResult.IsValid) {
			return Geocode.Response.Invalid(validationResult);
		}

		try {
			var response = await _httpClient.GetAsync(request.GetEndpoint(_options), cancellationToken).ConfigureAwait(false);
			var geocode = await response.Content.ReadFromJsonAsync<Geocode.Response>(_jsonSerializerOptions, cancellationToken).ConfigureAwait(false);

			geocode!.Errors = geocode.Error.HasValue()
				? [geocode.Error!]
				: geocode.Errors;

			return geocode;
		} catch {
			return Geocode.Response.Failed;
		}
	}

	public Task<GeocodeMany.Response> GeocodeManyAsync(
		IList<string> addresses,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default) => GeocodeManyAsync(new GeocodeMany.Request {
			Addresses = addresses,
			Take = mostAccurate
				? 1
				: null
		}, cancellationToken);

	public async Task<GeocodeMany.Response> GeocodeManyAsync(
		GeocodeMany.Request request,
		CancellationToken cancellationToken = default) {
		if (cancellationToken.IsSupportedAndCancelled()) {
			return GeocodeMany.Response.Cancelled;
		}

		// ReSharper disable once MethodHasAsyncOverloadWithCancellation
		var validationResult = _geocodeBatchValidator.Validate(request);

		if (!validationResult.IsValid) {
			return GeocodeMany.Response.Invalid(validationResult);
		}

		try {
			var response = await _httpClient.PostAsJsonAsync(request.GetEndpoint(_options), request.Addresses, _jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
			var geocodes = await response.Content.ReadFromJsonAsync<GeocodeMany.Response>(_jsonSerializerOptions, cancellationToken).ConfigureAwait(false);

			geocodes!.Errors = geocodes.Error.HasValue()
				? [geocodes.Error!]
				: geocodes.Errors;

			return geocodes;
		} catch {
			return GeocodeMany.Response.Failed;
		}
	}

	public Task<ReverseGeocode.Response> ReverseGeocodeAsync(
		decimal latitude,
		decimal longitude,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default) => ReverseGeocodeAsync(new ReverseGeocode.Request {
			Point = $"{latitude},{longitude}",
			Take = mostAccurate
				? 1
				: null
		}, cancellationToken);

	public Task<ReverseGeocode.Response> ReverseGeocodeAsync(
		string point,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default) => ReverseGeocodeAsync(new ReverseGeocode.Request {
			Point = point,
			Take = mostAccurate
				? 1
				: null
		}, cancellationToken);

	public async Task<ReverseGeocode.Response> ReverseGeocodeAsync(
		ReverseGeocode.Request request,
		CancellationToken cancellationToken = default) {
		if (cancellationToken.IsSupportedAndCancelled()) {
			return ReverseGeocode.Response.Cancelled;
		}

		// ReSharper disable once MethodHasAsyncOverloadWithCancellation
		var validationResult = _reverseGeocodeValidator.Validate(request);

		if (!validationResult.IsValid) {
			return ReverseGeocode.Response.Invalid(validationResult);
		}

		try {
			var response = await _httpClient.GetAsync(request.GetEndpoint(_options), cancellationToken).ConfigureAwait(false);
			var reverseGeocode = await response.Content.ReadFromJsonAsync<ReverseGeocode.Response>(_jsonSerializerOptions, cancellationToken).ConfigureAwait(false);

			reverseGeocode!.Errors = reverseGeocode.Error.HasValue()
				? [reverseGeocode.Error!]
				: reverseGeocode.Errors;

			return reverseGeocode;
		} catch {
			return ReverseGeocode.Response.Failed;
		}
	}

	public Task<ReverseGeocodeMany.Response> ReverseGeocodeManyAsync(
		IList<string> points,
		bool mostAccurate = true,
		CancellationToken cancellationToken = default) => ReverseGeocodeManyAsync(new ReverseGeocodeMany.Request {
			Points = points,
			Take = mostAccurate
				? 1
				: null
		}, cancellationToken);

	public async Task<ReverseGeocodeMany.Response> ReverseGeocodeManyAsync(
		ReverseGeocodeMany.Request request,
		CancellationToken cancellationToken = default) {
		if (cancellationToken.IsSupportedAndCancelled()) {
			return ReverseGeocodeMany.Response.Cancelled;
		}

		// ReSharper disable once MethodHasAsyncOverloadWithCancellation
		var validationResult = _reverseGeocodeBatchValidator.Validate(request);

		if (!validationResult.IsValid) {
			return ReverseGeocodeMany.Response.Invalid(validationResult);
		}

		try {
			var response = await _httpClient.PostAsJsonAsync(request.GetEndpoint(_options), request.Points, _jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
			var reverseGeocodes = await response.Content.ReadFromJsonAsync<ReverseGeocodeMany.Response>(_jsonSerializerOptions, cancellationToken).ConfigureAwait(false);

			reverseGeocodes!.Errors = reverseGeocodes.Error.HasValue()
				? [reverseGeocodes.Error!]
				: reverseGeocodes.Errors;

			return reverseGeocodes;
		} catch {
			return ReverseGeocodeMany.Response.Failed;
		}
	}
}