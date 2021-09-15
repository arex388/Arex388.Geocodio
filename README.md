﻿# Arex388.Geocodio

A C# client for the Geocod.io API.

To use, create a new instance of `GeocodioClient` and pass in an instance of `HttpClient` and your API key. The original API documentation can be found [here](https://www.geocod.io/docs). For more information, please visit [arex388.com](https://arex388.com ).

Available as a NuGet package [here](https://www.nuget.org/packages/Arex388.Geocodio).



## IMPORTANT

#### v1.6.1

Version 1.6.1 introduces some *breaking changes* in the form of a couple renamed properties. This version also rewrites the internal implementation of the `GeocodioClient` and makes all methods fully asynchronous and cancellable.

A new `Arex388.Geocodio.Extension.Microsoft.DependencyInjection` NuGet package is introduced to help with dependency injection. Finally a new `IGeocodioClient` interface is introduced, which is used by the dependency injection package. Please change all instances of `GeocodioClient` to instead be `IGeocodioClient`.

For more information please look at the changelog.



#### v1.4.2

Version 1.4.2 targets .NET Standard 2.0 now. I did this to resolve problems in my daily project targeting .NET Framework 4.8. There's also no real reason to stay on anything below .NET Standard 2.0 anyway. To quote Immo Landwerth from his [.NET Standard 2.1 announcement post](https://devblogs.microsoft.com/dotnet/announcing-net-standard-2-1/):

> *Library authors who need to support .NET Framework customers should stay on .NET Standard 2.0.*

There's also breaking changes in this version. I just renamed the methods to make them a little bit clearer and removed all of the *Get* prefixes from them. Look at the change log for more details.



## How to Use

You can either create an instance of `GeocodioClient` or inject its interface `IGeocodioClient` through dependency injection.



```C#
var geocodio = new GeocodioClient(
    httpClient,
    "{key}",
    debug		//	false by default
);
```



#### Geocode

```C#
var response = await geocodio.GeocodeAsync(
    "1600 Pennsylvania Ave NW, Washington, DC 20500",
    CancellationToken.None
).ConfigureAwait(false);
```



#### Geocode Batch

```C#
var response = await geocodio.GeocodeBatchAsync(new[] {
	"1600 Pennsylvania Ave NW, Washington, DC 20500",
	"East Capitol St NE & First St SE, Washington, DC 20004"
}, CancellationToken.None).ConfigureAwait(false);
```



#### Reverse Geocode

```C#
var response = await geocodio.ReverseGeocodeAsync(
    "38.897675,-77.036547",
    CancellationToken.None
).ConfigureAwait(false);
```



#### Reverse Geocode Batch

```C#
var response = await geocodio.ReverseGeocodeBatchAsync(new[] {
	"38.897675,-77.036547",
	"38.898976,-77.038219"
}, CancellationToken.None).ConfigureAwait(false);
```



#### Get Point of an Address

```c#
var (latitude, longitude) = await geocodio.GetPointAsync("1600 Pennsylvania Ave NW, Washington, DC 20500", CancellationToken.None).ConfigureAwait(false);
```



#### Fields

To request fields in the response there is a helper `FieldTypes` class which contains the strings of all available fields.

```C#
var response = await geocodio.GeocodeAsync(
    "1600 Pennsylvania Ave NW, Washington, DC 20500",
    FieldTypes.Census,
    CancellationToken.None
).ConfigureAwait(false);
```
