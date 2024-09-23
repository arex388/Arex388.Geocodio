using FluentValidation;
using static Arex388.Geocodio.ReverseGeocode;

namespace Arex388.Geocodio;

/// <summary>
/// Reverse geocode a single point.
/// </summary>
public static class ReverseGeocode {
	/// <summary>
	/// Reverse geocode request.
	/// </summary>
	public sealed class Request :
		RequestBase {
		internal override string Endpoint => GetEndpoint(this);

		/// <summary>
		/// The latitude/longitude point to reverse geocode.
		/// </summary>
		public required string Point { get; init; } = null!;

		//	========================================================================
		//	Utilities
		//	========================================================================

		private static string GetEndpoint(
			Request request) {
			var parameters = new HashSet<string> {
				$"q={request.Point}"
			};

			if (request.Fields.Any()) {
				parameters.Add($"fields={request.Fields.ToValues()}");
			}

			if (request.Take.HasValue) {
				parameters.Add($"limit={request.Take}");
			}

			return $"reverse/?{parameters.StringJoin("&")}";
		}
	}

	/// <summary>
	/// Reverse geocode response.
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
		RuleFor(r => r.Point).NotEmpty().Custom((s, c) => {
			if (!s.HasValue()) {
				return;
			}

			var parts = s.Split(',');

			if (parts.Length != 2) {
				c.AddFailure(c.PropertyPath, "The 'latitude' and 'longitude' values of the point could not be parsed.");

				return;
			}

			var latitudeParsed = decimal.TryParse(parts[0], out var latitude);
			var longitudeParsed = decimal.TryParse(parts[1], out var longitude);

			if (!latitudeParsed) {
				c.AddFailure(c.PropertyPath, "The 'latitude' of the point could not be parsed");
			}

			if (latitude is <= -90M or >= 90M) {
				c.AddFailure(c.PropertyPath, "The 'latitude' value is out of range. Must be between -90 and 90.");
			}

			if (!longitudeParsed) {
				c.AddFailure(c.PropertyPath, "The 'longitude' of the point could not be parsed");
			}

			if (longitude is <= -180M or >= 180M) {
				c.AddFailure(c.PropertyPath, "The 'longitude' value is out of range. Must be between -180 and 180.");
			}
		});
	}
}