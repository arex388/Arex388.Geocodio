using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsDataMeta {
    [JsonProperty("table_id")]
    public string TableId { get; set; }

    public string Universe { get; set; }
}