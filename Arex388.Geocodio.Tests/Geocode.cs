using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Arex388.Geocodio.Tests;

public sealed class Geocode {
    private readonly IGeocodioClient _geocodio;

    public Geocode() {
        var configuration = new ConfigurationBuilder().AddUserSecrets<Geocode>().Build();
        var key = configuration["GeocodioKey"];

        _geocodio = new GeocodioClient(new HttpClient(), key, true);
    }

    [Fact]
    public async Task GetAsync() {
        var response = await _geocodio.GeocodeAsync("1600 Pennsylvania Ave NW, Washington, DC 20500", CancellationToken.None).ConfigureAwait(false);

        var result = response.Results[0];

        Assert.Equal(1, result.Accuracy);
        Assert.Equal(AccuracyType.Rooftop, result.AccuracyType);
        Assert.Equal(38.897675M, result.Location.Latitude);
        Assert.Equal(-77.036547M, result.Location.Longitude);
    }
}