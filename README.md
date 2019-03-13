# Arex388.Geocodio

Geocod.io API Implementation in C#

To use, create a new instance of `GeocodioClient` and pass in an instance of `HttpClient` and your API key. The original API documentation can be found [here][0]. For more information, please visit [arex388.com][1].

Available as a NuGet package [here][2].

    var geocodio = new GeocodioClient(
        httpClient,
        "{key}",
        "{endpointVersion}"// optional
    );

**Get Geocode**

    var geocode = await geocodio.GetGeocodeAsync(
        "1600 Pennsylvania Ave NW, Washington, DC 20500"
    );

**Get Geocode Batch**

    var geocodeBatch = await geocodio.GetGeocodeBatchAsync(new[] {
		"1600 Pennsylvania Ave NW, Washington, DC 20500",
		"East Capitol St NE & First St SE, Washington, DC 20004"
	});

**Get Reverse Geocode**

    var reverse = await geocodio.GetReverseGeocodeAsync(
        "38.897675,-77.036547"
    );

**Get Reverse Geocode Batch**

    var reverseBatch = await geocodio.GetReverseGeocodeBatchAsync(new[] {
		"38.897675,-77.036547",
		"38.898976,-77.038219"
	});

**Fields**

To request fields in the response there is a helper `FieldTypes` class which contains the strings of all available fields.

    var geocode = await geocodio.GetGeocodeAsync(
        "1600 Pennsylvania Ave NW, Washington, DC 20500",
        FieldTypes.Census
    );

**Update 1.2.1 (2019-03-13)**

Fixed a small typeo on batch geocoding where the requested fields were not returned.

**Update 1.2.0 (2019-01-13)**

Now includes backwards compatibility. In the `GeocodioClient` constructor you can now pass a third argument for the endpoint version using `EndpointVersions` constants.

**Update 1.1.0 (2019-01-13)**

Now includes full support for all fields and their responses.

[0]:https://www.geocod.io/docs
[1]:https://arex388.com
[2]:https://www.nuget.org/packages/Arex388.Geocodio