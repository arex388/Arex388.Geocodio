using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class SchoolDistrict {
    [JsonProperty("grade_high")]
    public string HighestGrade { get; set; }

    [JsonProperty("lea_code")]
    public string LeaCode { get; set; }

    [JsonProperty("grade_low")]
    public string LowestGrade { get; set; }

    public string Name { get; set; }
}