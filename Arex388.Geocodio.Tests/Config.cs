using Microsoft.Extensions.Configuration;

namespace Arex388.Geocodio.Tests;

internal sealed class Config {
	private static readonly IConfigurationRoot _configuration = new ConfigurationManager().AddUserSecrets<Config>().Build();

	public static string Key = _configuration["key"]!;
}