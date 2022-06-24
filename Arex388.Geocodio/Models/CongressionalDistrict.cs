using System.Collections.Generic;
using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class CongressionalDistrict {
    [JsonProperty("congress_number")]
    public string CongressNumber { get; set; }

    [JsonProperty("congress_years")]
    public string CongressYears { get; set; }

    [JsonProperty("district_number")]
    public int DistrictNumber { get; set; }

    [JsonProperty("current_legislators")]
    public IList<CongressLegislator> Legislators { get; set; }

    /// <summary>
    ///	current_legislator was renamed to current_legislators (plural)
    /// and changed to a collection in v1.2.
    /// </summary>
    [JsonProperty("current_legislator")]
    private CongressLegislator Legislator {
        set => Legislators = new List<CongressLegislator> {
            value
        };
    }

    public string Name { get; set; }
    public int Proportion { get; set; }
}