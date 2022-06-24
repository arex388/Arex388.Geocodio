using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsPair {
    [JsonProperty("margin_of_error")]
    public decimal MarginOfError { get; set; }

    public decimal Percentage { get; set; }
    public decimal Value { get; set; }
}