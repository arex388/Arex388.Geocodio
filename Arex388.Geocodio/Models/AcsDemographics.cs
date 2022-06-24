using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsDemographics {
    [JsonProperty("Median age")]
    public AcsDemographicsMedianAge MedianAge { get; set; }

    [JsonProperty("Population by age range")]
    public AcsDemographicsPopulationByAge PopulationByAge { get; set; }

    [JsonProperty("Race and ethnicity")]
    public AcsDemographicsRace RaceEthnicity { get; set; }

    public AcsDemographicsSex Sex { get; set; }
}