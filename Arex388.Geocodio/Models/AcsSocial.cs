using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsSocial {
    /// <summary>
    /// Population by minimum level of education
    /// </summary>
    [JsonProperty("Population by minimum level of education")]
    public AcsSocialEducationStatus EducationStatus { get; set; }

    /// <summary>
    /// Period of military service for veterans
    /// </summary>
    [JsonProperty("Period of military service for veterans")]
    public AcsSocialMilitaryStatus MilitaryStatus { get; set; }

    /// <summary>
    /// Population with veteran status
    /// </summary>
    [JsonProperty("Population with veteran status")]
    public AcsSocialVeteranStatus VeteranStatus { get; set; }
}