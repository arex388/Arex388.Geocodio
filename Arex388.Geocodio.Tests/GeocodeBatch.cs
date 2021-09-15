using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Arex388.Geocodio.Tests {
    public sealed class GeocodeBatch {
        private readonly IGeocodioClient _geocodio;

        public GeocodeBatch() {
            var configuration = new ConfigurationBuilder().AddUserSecrets<GeocodeBatch>().Build();
            var key = configuration["GeocodioKey"];

            _geocodio = new GeocodioClient(new HttpClient(), key, true);
        }

        [Fact]
        public async Task PostAsync() {
            var response = await _geocodio.GeocodeBatchAsync(new[] {
                "1600 Pennsylvania Ave NW, Washington, DC 20500",
                "East Capitol St NE & First St SE, Washington, DC 20004"
            }, CancellationToken.None).ConfigureAwait(false);

            var batchResult = response.Results[0];

            batchResult.Query = "1600 Pennsylvania Ave NW, Washington, DC 20500";

            var result = batchResult.Response.Results[0];

            Assert.Equal(1, result.Accuracy);
            Assert.Equal(AccuracyType.Rooftop, result.AccuracyType);
            Assert.Equal(38.897675M, result.Location.Latitude);
            Assert.Equal(-77.036547M, result.Location.Longitude);
        }
    }
}