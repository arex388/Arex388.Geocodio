using Newtonsoft.Json;

namespace Arex388.Geocodio {
    public sealed class AcsFamiliesByPopulation {
        /// <summary>
        /// In family households
        /// </summary>
        [JsonProperty("In family households")]
        public AcsPair InFamily { get; set; }

        /// <summary>
        /// In family households: In married-couple family
        /// </summary>
        [JsonProperty("In family households: In married-couple family")]
        public AcsPair InFamilyMarried { get; set; }

        /// <summary>
        /// In family households: In married-couple family: Relatives
        /// </summary>
        [JsonProperty("In family households: In married-couple family: Relatives")]
        public AcsPair InFamilyMarriedRelatives { get; set; }

        /// <summary>
        /// In family households: In married-couple family: Nonrelatives
        /// </summary>
        [JsonProperty("In family households: In married-couple family: Nonrelatives")]
        public AcsPair InFamilyMarriedNonRelatives { get; set; }

        /// <summary>
        /// In family households: In female householder, no husband present, family
        /// </summary>
        [JsonProperty("In family households: In female householder, no husband present, family")]
        public AcsPair InFamilyFemaleNoHusband { get; set; }

        /// <summary>
        /// In family households: In female householder, no husband present, family: Relatives
        /// </summary>
        [JsonProperty("In family households: In female householder, no husband present, family: Relatives")]
        public AcsPair InFamilyFemaleNoHusbandRelatives { get; set; }

        /// <summary>
        /// In family households: In female householder, no husband present, family: Nonrelatives
        /// </summary>
        [JsonProperty("In family households: In female householder, no husband present, family: Nonrelatives")]
        public AcsPair InFamilyFemaleNoHusbandNonRelatives { get; set; }

        /// <summary>
        /// In family households: In male householder, no wife present, family
        /// </summary>
        [JsonProperty("In family households: In male householder, no wife present, family")]
        public AcsPair InFamilyMaleNoWife { get; set; }

        /// <summary>
        /// In family households: In male householder, no wife present, family: Relatives
        /// </summary>
        [JsonProperty("In family households: In male householder, no wife present, family: Relatives")]
        public AcsPair InFamilyMaleNoWifeRelatives { get; set; }

        /// <summary>
        /// In family households: In male householder, no wife present, family: Nonrelatives
        /// </summary>
        [JsonProperty("In family households: In male householder, no wife present, family: Nonrelatives")]
        public AcsPair InFamilyMaleNoWifeNonRelatives { get; set; }

        /// <summary>
        /// In nonfamily households
        /// </summary>
        [JsonProperty("In nonfamily households")]
        public AcsPair InNonFamily { get; set; }

        public AcsDataMeta Meta { get; set; }
        public AcsPair Total { get; set; }
    }
}