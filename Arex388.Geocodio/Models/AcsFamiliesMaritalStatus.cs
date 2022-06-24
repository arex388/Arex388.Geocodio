using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsFamiliesMaritalStatus {
    /// <summary>
    /// Female
    /// </summary>
    public AcsPair Female { get; set; }

    /// <summary>
    /// Female: Never married
    /// </summary>
    [JsonProperty("Female: Never married")]
    public AcsPair FemaleNeverMarried { get; set; }

    /// <summary>
    /// Female: Now married
    /// </summary>
    [JsonProperty("Female: Now married")]
    public AcsPair FemaleNowMarried { get; set; }

    /// <summary>
    /// Female: Now married: Married, spouse present
    /// </summary>
    [JsonProperty("Female: Now married: Married, spouse present")]
    public AcsPair FemaleNowMarriedSpousePresent { get; set; }

    /// <summary>
    /// Female: Now married: Married, spouse absent
    /// </summary>
    [JsonProperty("Female: Now married: Married, spouse absent")]
    public AcsPair FemaleNowMarriedSpouseAbsent { get; set; }

    /// <summary>
    /// Female: Now married: Married, spouse absent: Separated
    /// </summary>
    [JsonProperty("Female: Now married: Married, spouse absent: Separated")]
    public AcsPair FemaleNowMarriedSpouseAbsentSeparated { get; set; }

    /// <summary>
    /// Female: Now married: Married, spouse absent: Other
    /// </summary>
    [JsonProperty("Female: Now married: Married, spouse absent: Other")]
    public AcsPair FemaleNowMarriedSpouseAbsentOther { get; set; }

    /// <summary>
    /// Female: Widowed
    /// </summary>
    [JsonProperty("Female: Widowed")]
    public AcsPair FemaleWidowed { get; set; }

    /// <summary>
    /// Female: Divorced
    /// </summary>
    [JsonProperty("Female: Divorced")]
    public AcsPair FemaleDivorced { get; set; }

    /// <summary>
    /// Male
    /// </summary>
    [JsonProperty("Male")]
    public AcsPair Male { get; set; }

    /// <summary>
    /// Male: Never married
    /// </summary>
    [JsonProperty("Male: Never married")]
    public AcsPair MaleNeverMarried { get; set; }

    /// <summary>
    /// Male: Now married
    /// </summary>
    [JsonProperty("Male: Now married")]
    public AcsPair MaleNowMarried { get; set; }

    /// <summary>
    /// Male: Now married: Married, spouse present
    /// </summary>
    [JsonProperty("Male: Now married: Married, spouse present")]
    public AcsPair MaleNowMarriedSpousePresent { get; set; }

    /// <summary>
    /// Male: Now married: Married, spouse absent
    /// </summary>
    [JsonProperty("Male: Now married: Married, spouse absent")]
    public AcsPair MaleNowMarriedSpouseAbsent { get; set; }

    /// <summary>
    /// Male: Now married: Married, spouse absent: Separated
    /// </summary>
    [JsonProperty("Male: Now married: Married, spouse absent: Separated")]
    public AcsPair MaleNowMarriedSpouseAbsentSeparated { get; set; }

    /// <summary>
    /// Male: Now married: Married, spouse absent: Other
    /// </summary>
    [JsonProperty("Male: Now married: Married, spouse absent: Other")]
    public AcsPair MaleNowMarriedSpouseAbsentOther { get; set; }

    /// <summary>
    /// Male: Widowed
    /// </summary>
    [JsonProperty("Male: Widowed")]
    public AcsPair MaleWidowed { get; set; }

    /// <summary>
    /// Male: Divorced
    /// </summary>
    [JsonProperty("Male: Divorced")]
    public AcsPair MaleDivorced { get; set; }

    public AcsDataMeta Meta { get; set; }
}