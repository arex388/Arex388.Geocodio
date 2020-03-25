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