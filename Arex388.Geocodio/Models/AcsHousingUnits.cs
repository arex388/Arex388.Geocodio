using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsHousingUnits {
    public AcsDataMeta Meta { get; set; }

    /// <summary>
    /// 1, attached unit
    /// </summary>
    [JsonProperty("1, attached unit")]
    public AcsPair OneAttached { get; set; }

    /// <summary>
    /// 1, detached unit
    /// </summary>
    [JsonProperty("1, detached unit")]
    public AcsPair OneDetached { get; set; }

    /// <summary>
    /// 2 units
    /// </summary>
    [JsonProperty("2 units")]
    public AcsPair Two { get; set; }

    /// <summary>
    /// 3 or 4 units
    /// </summary>
    [JsonProperty("3 or 4 units")]
    public AcsPair Range3To4 { get; set; }

    /// <summary>
    /// 5 to 9 units
    /// </summary>
    [JsonProperty("5 to 9 units")]
    public AcsPair Range5To9 { get; set; }

    /// <summary>
    /// 10 to 19 unit
    /// </summary>
    [JsonProperty("10 to 19 unit")]
    public AcsPair Range10To19 { get; set; }

    /// <summary>
    /// 20 to 49 units
    /// </summary>
    [JsonProperty("20 to 49 units")]
    public AcsPair Range20To49 { get; set; }

    /// <summary>
    /// 50 or more units
    /// </summary>
    [JsonProperty("50 or more units")]
    public AcsPair Range50OrMore { get; set; }

    /// <summary>
    /// Mobile home units
    /// </summary>
    [JsonProperty("Mobile home units")]
    public AcsPair Mobile { get; set; }

    /// <summary>
    /// Boat, RV, van, etc. units
    /// </summary>
    [JsonProperty("Boat, RV, van, etc. units")]
    public AcsPair Other { get; set; }
}