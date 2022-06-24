using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsFamilies {
    /// <summary>
    /// Household type by household
    /// </summary>
    [JsonProperty("Household type by household")]
    public AcsFamiliesByHousehold ByHousehold { get; set; }

    /// <summary>
    /// Household type by population
    /// </summary>
    [JsonProperty("Household type by population")]
    public AcsFamiliesByPopulation ByPopulation { get; set; }

    /// <summary>
    /// Marital status
    /// </summary>
    [JsonProperty("Marital status")]
    public AcsFamiliesMaritalStatus MaritalStatus { get; set; }
}