using System.Diagnostics.CodeAnalysis;

namespace System;

internal static class StringExtensions {
	public static bool HasValue(
		[NotNullWhen(true)]
		this string? value) => !string.IsNullOrEmpty(value);

	public static string StringJoin<T>(
		this IEnumerable<T> values,
		string? separator = null) => string.Join(separator, values);
}