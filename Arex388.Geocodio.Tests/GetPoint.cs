using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Arex388.Geocodio.Tests {
    public sealed class GetPoint {
        private readonly IGeocodioClient _geocodio;

        public GetPoint() {
            var configuration = new ConfigurationBuilder().AddUserSecrets<GetPoint>().Build();
            var key = configuration["GeocodioKey"];

            _geocodio = new GeocodioClient(new HttpClient(), key, true);
        }

        [Fact]
        public async Task GetAsync() {
            var response = await _geocodio.GetPointAsync("1600 Pennsylvania Ave NW, Washington, DC 20500", CancellationToken.None).ConfigureAwait(false);

            Assert.True(response.HasValue);
            Assert.Equal(38.897675M, response!.Value.latitude);
            Assert.Equal(-77.036547M, response.Value.longitude);
        }
    }
}