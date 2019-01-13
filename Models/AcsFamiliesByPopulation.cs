using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsFamiliesByPopulation {
		/// <summary>
		/// In family households
		/// </summary>
		[JsonProperty("In family households")]
		public AcsPair InFamily { get; set; }

		/// <summary>
		/// In married-couple family
		/// </summary>
		[JsonProperty("In married-couple family")]
		public AcsPair InMarriedFamily { get; set; }

		/// <summary>
		/// In married-couple family: Relatives
		/// </summary>
		[JsonProperty("In married-couple family: Relatives")]
		public AcsPair InMarriedFamilyRelatives { get; set; }

		/// <summary>
		/// In married-couple family: Nonrelatives
		/// </summary>
		[JsonProperty("In married-couple family: Nonrelatives")]
		public AcsPair InMarriedFamilyNonRelatives { get; set; }

		/// <summary>
		/// In male householder, no wife present, family
		/// </summary>
		[JsonProperty("In male householder, no wife present, family")]
		public AcsPair InFamilyMaleNoWife { get; set; }

		/// <summary>
		/// In male householder, no wife present, family: Relatives
		/// </summary>
		[JsonProperty("In male householder, no wife present, family: Relatives")]
		public AcsPair InFamilyMaleNoWifeRelatives { get; set; }

		/// <summary>
		/// In male householder, no wife present, family: Nonrelatives
		/// </summary>
		[JsonProperty("In male householder, no wife present, family: Nonrelatives")]
		public AcsPair InFamilyMaleNoWifeNonRelatives { get; set; }

		/// <summary>
		/// In female householder, no husband present, family
		/// </summary>
		[JsonProperty("In female householder, no husband present, family")]
		public AcsPair InFamilyFemaleNoHusband { get; set; }

		/// <summary>
		/// In female householder, no husband present, family: Relatives
		/// </summary>
		[JsonProperty("In female householder, no husband present, family: Relatives")]
		public AcsPair InFamilyFemaleNoHusbandRelatives { get; set; }

		/// <summary>
		/// In female householder, no husband present, family: Nonrelatives
		/// </summary>
		[JsonProperty("In female householder, no husband present, family: Nonrelatives")]
		public AcsPair InFamilyFemaleNoHusbandNonRelatives { get; set; }

		/// <summary>
		/// In female householder, no husband present, family: In nonfamily households
		/// </summary>
		[JsonProperty("In female householder, no husband present, family: In nonfamily households")]
		public AcsPair InFamilyFemaleNoHusbandNonFamily { get; set; }

		public AcsDataMeta Meta { get; set; }
		public AcsPair Total { get; set; }
	}
}