using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Arex388.Geocodio.Tests; 

public sealed class ReverseGeocode {
    private readonly IGeocodioClient _geocodio;

    public ReverseGeocode() {
        var configuration = new ConfigurationBuilder().AddUserSecrets<ReverseGeocode>().Build();
        var key = configuration["GeocodioKey"];

        _geocodio = new GeocodioClient(new HttpClient(), key, true);
    }

    [Fact]
    public async Task GetAsync() {
        var response = await _geocodio.ReverseGeocodeAsync("38.897675,-77.036547", CancellationToken.None).ConfigureAwait(false);

        var result = response.Results[0];

        Assert.Equal(1, result.Accuracy);
        Assert.Equal(AccuracyType.Rooftop, result.AccuracyType);
        Assert.Equal("1600 Pennsylvania Ave NW, Washington, DC 20500", result.FormattedAddress);
    }
}