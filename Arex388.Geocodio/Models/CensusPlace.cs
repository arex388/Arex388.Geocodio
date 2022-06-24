using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class CensusPlace {
    /// <summary>
    /// The 7-digit place FIPS code. A place is defined as a city or other census designated area. A full list of ANSI codes is available from the U.S. Census Bureau
    /// </summary>
    [JsonProperty("fips")]
    public string FipsCode { get; set; }

    /// <summary>
    /// The official Census-designated name for the place
    /// </summary>
    public string Name { get; set; }
}