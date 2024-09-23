# Arex388.Geocodio

> [!CAUTION]
>
> This README only refers to the v2.0.0 version of the library only.



Arex388.Geocodio is a highly opinionated .NET Standard 2.0 library for the [Geocod.io](https://www.geocod.io/docs) API. It is intended to be an easy, well structured, and highly performant client for interacting with the Geocod.io API for forward and reverse geocoding of addresses and points. It can be used in applications interacting with a single account using `IGeocodioClient`, or with applications interacting with multiple accounts using `IGeocodioClientFactory`.

- [Changelog](CHANGELOG.md)
- [Benchmarks](BENCHMARKS)



#### Dependency Injection

To configure dependency injection use the `AddGeocodio()` extensions on `IServiceCollection`. There are two signatures, with and without passing in a `GeocodioClientOptions` object. If the options object is passed to the extension, it will register `IGeocodioClient` for use with a single account, otherwise it will register `IGeocodioClientFactory` for use with multiple accounts.



#### How to Use

For a single account, inject the `IGeocodioClient`.

```c#
private readonly IGeocodioClient _geocodio;

_ = await _geocodio.GeocodeAsync("The address to geocode");
_ = await _geocodio.ReverseGeocodeAsync("The point to reverse geocode");
```



For multiple accounts, inject the `IGeocodioClientFactory` to create an instance per account.

```c#
private readonly IGeocodioClientFactory _geocodioFactory;

var geocodio = _geocodio.CreateClient(new GeocodioClientOptions {
    Key = "Your key from Geocod.io"
});

_ = await geocodio.GeocodeAsync("The address to geocode");
_ = await geocodio.ReverseGeocodeAsync("The point to reverse goeocode");
```



The client provides methods for interacting with Geocode and Reverse Geocode using the following methods:

###### Geocode

- `GeocodeAsync()` - Geocode a single address.
- `GeocodeManyAsync()` - Geocode multiple addresses.



###### Reverse Geocode

- `ReverseGeocodeAsync()` - Reverse geocode a single point.
- `ReverseGeocodeManyAsync()` - Reverse geocode multiple points.
