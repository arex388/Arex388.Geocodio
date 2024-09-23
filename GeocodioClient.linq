<Query Kind="Program">
  <Reference Relative="Arex388.Geocodio\bin\Debug\netstandard2.0\Arex388.Geocodio.dll">E:\Software Development\Arex388.Geocodio\Arex388.Geocodio\bin\Debug\netstandard2.0\Arex388.Geocodio.dll</Reference>
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>Arex388.Geocodio</Namespace>
  <Namespace>Microsoft.Extensions.DependencyInjection</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Text.Json</Namespace>
</Query>

private static readonly GeocodioClientOptions _options = new GeocodioClientOptions {
	Key = Util.GetPassword("")
};

async Task Main() {
	//var geocodio = GetClientMultiple();
	var geocodio = GetClientSingle();
}

public IGeocodioClient GetClientMultiple() {
	var services = new ServiceCollection().AddGeocodio().BuildServiceProvider();
	var geocodioFactory = services.GetRequiredService<IGeocodioClientFactory>();
	
	return geocodioFactory.CreateClient(_options);
}

public IGeocodioClient GetClientSingle() {
	var services = new ServiceCollection().AddGeocodio(_options).BuildServiceProvider();

	return services.GetRequiredService<IGeocodioClient>();
}

//	============================================================================
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//	EoF