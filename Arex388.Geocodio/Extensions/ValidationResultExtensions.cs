namespace FluentValidation.Results;

internal static class ValidationResultExtensions {
	public static IList<string> ToErrors(
		this ValidationResult validationResult) => validationResult.Errors.Select(
		e => e.ErrorMessage).ToList();
}