# Arex388.Geocodio

A C# client for the Geocod.io API.

To use, create a new instance of `GeocodioClient` and pass in an instance of `HttpClient` and your API key. The original API documentation can be found [here][0]. For more information, please visit [arex388.com][1].

Available as a NuGet package [here][2].

```C#
var geocodio = new GeocodioClient(
    httpClient,
    "{key}"
);
```

#### Geocode

```C#
var response = await geocodio.GetGeocodeAsync(
    "1600 Pennsylvania Ave NW, Washington, DC 20500"
);
```

#### Geocode Batch

```C#
var response = await geocodio.GetGeocodeBatchAsync(new[] {
	"1600 Pennsylvania Ave NW, Washington, DC 20500",
	"East Capitol St NE & First St SE, Washington, DC 20004"
});
```

#### Reverse Geocode

```C#
var response = await geocodio.GetReverseGeocodeAsync(
    "38.897675,-77.036547"
);
```

#### Reverse Geocode Batch

```C#
var response = await geocodio.GetReverseGeocodeBatchAsync(new[] {
	"38.897675,-77.036547",
	"38.898976,-77.038219"
});
```

#### Fields

To request fields in the response there is a helper `FieldTypes` class which contains the strings of all available fields.

```C#
var response = await geocodio.GetGeocodeAsync(
    "1600 Pennsylvania Ave NW, Washington, DC 20500",
    FieldTypes.Census
);
```

[0]:https://www.geocod.io/docs
[1]:https://arex388.com
[2]:https://www.nuget.org/packages/Arex388.Geocodio