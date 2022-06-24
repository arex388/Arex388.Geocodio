using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Arex388.Geocodio.Tests; 

public sealed class ReverseGeocodeBatch {
    private readonly IGeocodioClient _geocodio;

    public ReverseGeocodeBatch() {
        var configuration = new ConfigurationBuilder().AddUserSecrets<ReverseGeocodeBatch>().Build();
        var key = configuration["GeocodioKey"];

        _geocodio = new GeocodioClient(new HttpClient(), key, true);
    }

    [Fact]
    public async Task PostAsync() {
        var response = await _geocodio.ReverseGeocodeBatchAsync(new[] {
            "38.897675,-77.036547",
            "38.898976,-77.038219"
        }, CancellationToken.None).ConfigureAwait(false);

        var batchResult = response.Results[0];

        batchResult.Query = "38.897675,-77.036547";

        var result = batchResult.Response.Results[0];

        Assert.Equal(1, result.Accuracy);
        Assert.Equal(AccuracyType.Rooftop, result.AccuracyType);
        Assert.Equal("1600 Pennsylvania Ave NW, Washington, DC 20500", result.FormattedAddress);
    }
}