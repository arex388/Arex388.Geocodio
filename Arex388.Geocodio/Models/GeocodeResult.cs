using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class GeocodeResult {
    public decimal Accuracy { get; set; }

    [JsonProperty("accuracy_type")]
    public string AccuracyType { get; set; }

    public Fields Fields { get; set; }

    [JsonProperty("formatted_address")]
    public string FormattedAddress { get; set; }

    [JsonProperty("address_components")]
    public GeocodeComponents Components { get; set; }

    public GeocodeLocation Location { get; set; }
    public string Source { get; set; }
}