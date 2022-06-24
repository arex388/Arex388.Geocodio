using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsEconomics {
    /// <summary>
    /// Number of households
    /// </summary>
    [JsonProperty("Number of households")]
    public AcsEconomicsHouseholds Households { get; set; }

    /// <summary>
    /// Household income
    /// </summary>
    [JsonProperty("Household income")]
    public AcsEconomicsHouseholdIncome HouseholdIncome { get; set; }

    /// <summary>
    /// Median household income
    /// </summary>
    [JsonProperty("Median household income")]
    public AcsEconomicsMedianIncome MedianIncome { get; set; }
}