using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class CongressLegislatorSocial {
    public string Facebook { get; set; }

    [JsonProperty("rss_url")]
    public string RssUrl { get; set; }

    public string Twitter { get; set; }
    public string YouTube { get; set; }

    [JsonProperty("youtube_id")]
    public string YouTubeId { get; set; }
}