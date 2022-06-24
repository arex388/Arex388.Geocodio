using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class CensusArea {
    /// <summary>
    /// Unique code for the area, also known as the CBSA code (MSA) OR the unique census-defined code for the area (CSA)
    /// </summary>
    [JsonProperty("area_code")]
    public string Code { get; set; }

    /// <summary>
    /// The official Census-designated name for the area
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Can either be "metropolitan" or "micropolitan"
    /// </summary>
    public string Type { get; set; }
}