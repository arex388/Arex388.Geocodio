using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsSocialEducationStatus {
    public AcsPair Female { get; set; }

    /// <summary>
    /// Female: No schooling completed
    /// </summary>
    [JsonProperty("Female: No schooling completed")]
    public AcsPair FemaleNoSchoolCompleted { get; set; }

    /// <summary>
    /// Female: Nursery to 4th grade
    /// </summary>
    [JsonProperty("Female: Nursery to 4th grade")]
    public AcsPair FemaleRangeNurseryTo4ThGrade { get; set; }

    /// <summary>
    /// Female: 5th and 6th grade
    /// </summary>
    [JsonProperty("Female: 5th and 6th grade")]
    public AcsPair FemaleRange5ThAnd6ThGrade { get; set; }

    /// <summary>
    /// Female: 7th and 8th grade
    /// </summary>
    [JsonProperty("Female: 7th and 8th grade")]
    public AcsPair FemaleRange7ThAnd8ThGrade { get; set; }

    /// <summary>
    /// Female: 9th grade
    /// </summary>
    [JsonProperty("Female: 9th grade")]
    public AcsPair Female9ThGrade { get; set; }

    /// <summary>
    /// Female: 10th grade
    /// </summary>
    [JsonProperty("Female: 10th grade")]
    public AcsPair Female10ThGrade { get; set; }

    /// <summary>
    /// Female: 11th grade
    /// </summary>
    [JsonProperty("Female: 11th grade")]
    public AcsPair Female11ThGrade { get; set; }

    /// <summary>
    /// Female: 12th grade, no diploma
    /// </summary>
    [JsonProperty("Female: 12th grade, no diploma")]
    public AcsPair Female12ThGradeNoDiploma { get; set; }

    /// <summary>
    /// Female: High school graduate (includes equivalency)
    /// </summary>
    [JsonProperty("Female: High school graduate (includes equivalency)")]
    public AcsPair FemaleHighSchoolCompleted { get; set; }

    /// <summary>
    /// Female: Some college, less than 1 year
    /// </summary>
    [JsonProperty("Female: Some college, less than 1 year")]
    public AcsPair FemaleCollegeLessThan1Year { get; set; }

    /// <summary>
    /// Female: Some college, 1 or more years, no degree
    /// </summary>
    [JsonProperty("Female: Some college, 1 or more years, no degree")]
    public AcsPair FemaleCollegeMoreThan1YearNoDegree { get; set; }

    /// <summary>
    /// Female: Associate's degree
    /// </summary>
    [JsonProperty("Female: Associate's degree")]
    public AcsPair FemaleAssociatesDegree { get; set; }

    /// <summary>
    /// Female: Bachelor's degree
    /// </summary>
    [JsonProperty("Female: Bachelor's degree")]
    public AcsPair FemaleBachelorsDegree { get; set; }

    /// <summary>
    /// Female: Master's degree
    /// </summary>
    [JsonProperty("Female: Master's degree")]
    public AcsPair FemaleMasterDegree { get; set; }

    /// <summary>
    /// Female: Professional school degree
    /// </summary>
    [JsonProperty("Female: Professional school degree")]
    public AcsPair FemaleProfessionalDegree { get; set; }

    /// <summary>
    /// Female: Doctorate degree
    /// </summary>
    [JsonProperty("Female: Doctorate degree")]
    public AcsPair FemaleDoctorateDegree { get; set; }

    public AcsPair Male { get; set; }

    /// <summary>
    /// Male: No schooling completed
    /// </summary>
    [JsonProperty("Male: No schooling completed")]
    public AcsPair MaleNoSchoolCompleted { get; set; }

    /// <summary>
    /// Male: Nursery to 4th grade
    /// </summary>
    [JsonProperty("Male: Nursery to 4th grade")]
    public AcsPair MaleRangeNurseryTo4ThGrade { get; set; }

    /// <summary>
    /// Male: 5th and 6th grade
    /// </summary>
    [JsonProperty("Male: 5th and 6th grade")]
    public AcsPair MaleRange5ThAnd6ThGrade { get; set; }

    /// <summary>
    /// Male: 7th and 8th grade
    /// </summary>
    [JsonProperty("Male: 7th and 8th grade")]
    public AcsPair MaleRange7ThAnd8ThGrade { get; set; }

    /// <summary>
    /// Male: 9th grade
    /// </summary>
    [JsonProperty("Male: 9th grade")]
    public AcsPair Male9ThGrade { get; set; }

    /// <summary>
    /// Male: 10th grade
    /// </summary>
    [JsonProperty("Male: 10th grade")]
    public AcsPair Male10ThGrade { get; set; }

    /// <summary>
    /// Male: 11th grade
    /// </summary>
    [JsonProperty("Male: 11th grade")]
    public AcsPair Male11ThGrade { get; set; }

    /// <summary>
    /// Male: 12th grade, no diploma
    /// </summary>
    [JsonProperty("Male: 12th grade, no diploma")]
    public AcsPair Male12ThGradeNoDiploma { get; set; }

    /// <summary>
    /// Male: High school graduate (includes equivalency)
    /// </summary>
    [JsonProperty("Male: High school graduate (includes equivalency)")]
    public AcsPair MaleHighSchoolCompleted { get; set; }

    /// <summary>
    /// Male: Some college, less than 1 year
    /// </summary>
    [JsonProperty("Male: Some college, less than 1 year")]
    public AcsPair MaleCollegeLessThan1Year { get; set; }

    /// <summary>
    /// Male: Some college, 1 or more years, no degree
    /// </summary>
    [JsonProperty("Male: Some college, 1 or more years, no degree")]
    public AcsPair MaleCollegeMoreThan1YearNoDegree { get; set; }

    /// <summary>
    /// Male: Associate's degree
    /// </summary>
    [JsonProperty("Male: Associate's degree")]
    public AcsPair MaleAssociatesDegree { get; set; }

    /// <summary>
    /// Male: Bachelor's degree
    /// </summary>
    [JsonProperty("Male: Bachelor's degree")]
    public AcsPair MaleBachelorsDegree { get; set; }

    /// <summary>
    /// Male: Master's degree
    /// </summary>
    [JsonProperty("Male: Master's degree")]
    public AcsPair MaleMasterDegree { get; set; }

    /// <summary>
    /// Male: Professional school degree
    /// </summary>
    [JsonProperty("Male: Professional school degree")]
    public AcsPair MaleProfessionalDegree { get; set; }

    /// <summary>
    /// Male: Doctorate degree
    /// </summary>
    [JsonProperty("Male: Doctorate degree")]
    public AcsPair MaleDoctorateDegree { get; set; }

    public AcsDataMeta Meta { get; set; }
    public AcsPair Total { get; set; }
}