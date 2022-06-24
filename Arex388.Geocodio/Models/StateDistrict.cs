using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class StateDistrict {
    public string Name { get; set; }

    [JsonProperty("district_number")]
    public int Number { get; set; }
}