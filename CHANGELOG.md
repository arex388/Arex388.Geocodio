#### 1.6.1 (2022-06-23)

- Minor code cleanup.

#### 1.6.1 (2021-09-13)

This update started with only one minor goal in time, which I don't even remember anymore, and then escalated into a rewrite of the entire client with lots of improvements.

- **Added** - A `GetPointAsync` extension method to get only the most accurate latitude and longitude point of an address.
- **Revised** - The internal implementation of `GeocodioClient` to be fully asynchronous and cancellable.
- **Added** - An `IGeocodioClient` interface to use for dependency injection.
- **Updated** - `AccuracyType` with improved descriptions.
- **Revised** - All request and response objects to be better structured.
- **Added** - A new `ResponseStatus` enum that better indicates the status of a response.
- **Added** - A new `Arex388.Geocodio.Extensions.Microsoft.DependencyInjection` NuGet package to quickly and easily add the client to `IServiceCollection` for dependency injection.
- **Added** - Basic unit tests so I don't have to use LINQPad for testing anymore.

#### 1.6.0 (2020-07-04)

- Updated to target v1.6 of the API.
- Matched API corrections for ACS results. This introduced breaking changes due to renaming of properties.

#### 1.5.0 (2020-07-04)

- Updated to target v1.5 of the API.
- Added Zip4 data append field and models.

#### 1.4.5 (2020-05-27)

- Internal code clean up.

#### 1.4.4 (2020-05-07)

- Internal cleanup and hopefully performance optimizations by adding `ConfigureAwait(false)` to all `await` calls.

#### 1.4.3 (2020-03-27)

- Added a timed out response for when a `TaskCancelledException` is thrown when the HttpClient times out.

#### 1.4.2 (2020-03-24)

- Targeting .NET Standard 2.0 now.
- Changed all `const string` properties to `static readonly string`.
- Renamed `GetGeocodeAsync` to `GeocodeAsync`.
- Renamed `GetGeocodeBatchAsync` to `GeocodeBatchAsync`.
- Renamed `GetReverseGeocodeAsync` to `ReverseGeocodeAsync`.
- Renamed `GetReverseGeocodeBatchAsync` to `ReverseGeocodeBatchAsync`.
- Changed over-batch limit requests to return a failure response instead of throwing an exception.
- Enabled XML documentation to be generated for intellisense.
- Added `Json` to `ResponseBase` to capture the raw JSON response from the API.
- Added `debug` parameter to the `GeocodioClient` constructor. False by default. When set to true, the raw JSON response will be written to the `Json` property of the response.
- Internal code clean up and rearrangement.

#### 1.4.1 (2020-02-03)

- Changed the invalid request response object.
- Changed the read me to be clearer.

#### 1.4.0 (2020-02-03)

- Added a response object when checking if request is null instead of returning null.
- Added `Census.Place`.
- Added fields to `FieldTypes` for Census years 2010 - 2019.
- Changed Census response to be an `IDictionary<string, Census>`.
- Changed framework target to .NET Standard 1.3.
- Changed client to permanently target API v1.4.
- Changed version to match API version going forward.
- Removed backward compatibility since it is becoming difficult to achieve as the API progresses in versions.
- Removed `EndpointVersions`.
- Removed `Census.PlaceFipsCode`.

#### 1.2.3 (2019-11-30)

- Added a `UtcOffsetNormalized` helper property to `TimeZone`.

#### 1.2.2 (2019-04-27)

- Added Metropolitan Divisions and Census responses.

#### 1.2.1 (2019-03-13)

- Fixed a small typo on batch geocoding where the requested fields were not returned.

#### 1.2.0 (2019-01-13)

- Now includes backwards compatibility. In the `GeocodioClient` constructor you can now pass a third argument for the endpoint version using `EndpointVersions` constants.

#### 1.1.0 (2019-01-13)

- Now includes full support for all fields and their responses.