using FluentValidation;
using static Arex388.Geocodio.GeocodeMany;

namespace Arex388.Geocodio;

/// <summary>
/// Geocode multiple addresses.
/// </summary>
public static class GeocodeMany {
	/// <summary>
	/// Geocode batch request.
	/// </summary>
	public sealed class Request :
		RequestBase {
		/// <summary>
		/// The addresses to geocode.
		/// </summary>
		public required IList<string> Addresses { get; init; } = [];

		internal override string Endpoint => GetEndpoint(this);

		//	========================================================================
		//	Utilities
		//	========================================================================

		private static string GetEndpoint(
			Request request) {
			var parameters = new HashSet<string>();

			if (request.Fields.Any()) {
				parameters.Add($"fields={request.Fields.ToValues()}");
			}

			if (request.Take.HasValue) {
				parameters.Add($"limit={request.Take}");
			}

			return $"geocode/?{parameters.StringJoin("&")}";
		}
	}

	/// <summary>
	/// Geocode batch response.
	/// </summary>
	public sealed class Response :
		ResponseBase<Response> {
		/// <summary>
		/// The results.
		/// </summary>
		public IList<GeocodeBatchResult> Results { get; init; } = [];
	}
}

//	================================================================================
//	Validators
//	================================================================================

file sealed class RequestValidator :
	AbstractValidator<Request> {
	public RequestValidator() {
		RuleFor(r => r.Addresses).NotEmpty();
	}
}