using System.Text.Json;
using System.Text.Json.Serialization;

namespace Xunit.Abstractions;

public static class TestOutputHelperExtensions {
	private static readonly JsonSerializerOptions _jsonSerializerOptions = new() {
		WriteIndented = true
	};

	private const char _equals = '=';
	private const string _na = "N/A";

	/// <summary>
	/// Add a JSON converter to the internal JSON serializer options.
	/// </summary>
	/// <typeparam name="TConverter">The JSON converter.</typeparam>
	public static ITestOutputHelper AddConverter<TConverter>(
		this ITestOutputHelper console)
		where TConverter : JsonConverter, new() {
		_jsonSerializerOptions.Converters.Add(new TConverter());

		return console;
	}

	/// <summary>
	/// Write an empty line to the console.
	/// </summary>
	public static void WriteLine(
		this ITestOutputHelper console) => console.WriteLine(string.Empty);

	/// <summary>
	/// Write an object, serialized as JSON, to the console.
	/// </summary>
	public static void WriteLine(
		this ITestOutputHelper console,
		object? obj) {
		var json = obj is null
			? _na
			: JsonSerializer.Serialize(obj, _jsonSerializerOptions);

		console.WriteLine(json);
	}

	/// <summary>
	/// Write a header and object, serialized as JSON, to the console and wrap the header with "=[ HEADER ]=".
	/// </summary>
	public static void WriteLineWithHeader(
		this ITestOutputHelper console,
		string header,
		object? obj) {
		var json = obj is null
			? _na
			: JsonSerializer.Serialize(obj, _jsonSerializerOptions);

		console.WriteLineWithHeader(header, json);
	}

	/// <summary>
	/// Write a header and JSON to the console output and wrap the header with "=[ HEADER ]=".
	/// </summary>
	public static void WriteLineWithHeader(
		this ITestOutputHelper console,
		string header,
		string? json = _na) {
		console.WriteLine($"=[ {header} ]{new string(_equals, 75 - header.Length)}");
		console.WriteLine();
		console.WriteLine(json);
		console.WriteLine();
	}
}