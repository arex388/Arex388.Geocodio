using FluentValidation;
using static Arex388.Geocodio.Geocode;

namespace Arex388.Geocodio;

/// <summary>
/// Geocode a single address.
/// </summary>
public static class Geocode {
	/// <summary>
	/// Geocode request.
	/// </summary>
	public sealed class Request :
		RequestBase {
		/// <summary>
		/// The address to geocode.
		/// </summary>
		public string? Address { get; init; }

		/// <summary>
		/// The addresses' city component.
		/// </summary>
		public string? City { get; init; }

		/// <summary>
		/// The addresses' country component.
		/// </summary>
		public string? Country { get; init; }

		internal override string Endpoint => GetEndpoint(this);

		/// <summary>
		/// The addresses' postal code component.
		/// </summary>
		public string? PostalCode { get; init; }

		/// <summary>
		/// The addresses' state component.
		/// </summary>
		public string? State { get; init; }

		/// <summary>
		/// The addresses' street component.
		/// </summary>
		public string? Street { get; init; }

		//	========================================================================
		//	Utilities
		//	========================================================================

		private static string GetEndpoint(
			Request request) {
			var parameters = new HashSet<string> {
				$"q={request.Address}"
			};

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
	/// Geocode response.
	/// </summary>
	public sealed class Response :
		ResponseBase<Response> {
		/// <summary>
		/// The results.
		/// </summary>
		public IList<GeocodeResult> Results { get; init; } = [];
	}
}

//	================================================================================
//	Validators
//	================================================================================

file sealed class RequestValidator :
	AbstractValidator<Request> {
	public RequestValidator() {
		RuleFor(r => r.Address).NotEmpty().When(r => !r.Street.HasValue());
		RuleFor(r => r.City).NotEmpty().When(r => !r.Address.HasValue());
		RuleFor(r => r.Country).NotEmpty().When(r => !r.Address.HasValue());
		RuleFor(r => r.PostalCode).NotEmpty().When(r => !r.Address.HasValue());
		RuleFor(r => r.State).NotEmpty().When(r => !r.Address.HasValue());
		RuleFor(r => r.Street).NotEmpty().When(r => !r.Address.HasValue());
	}
}