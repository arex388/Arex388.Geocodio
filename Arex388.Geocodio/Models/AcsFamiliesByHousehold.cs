using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsFamiliesByHousehold {
		/// <summary>
		/// Family households
		/// </summary>
		[JsonProperty("Family households")]
		public AcsPair Family { get; set; }

		/// <summary>
		/// Family households: Married-couple family
		/// </summary>
		[JsonProperty("Family households: Married-couple family")]
		public AcsPair FamilyMarried { get; set; }

		/// <summary>
		/// Family households: Other family
		/// </summary>
		[JsonProperty("Family households: Other family")]
		public AcsPair FamilyOther { get; set; }

		/// <summary>
		/// Family households: Other family: Female householder, no husband present
		/// </summary>
		[JsonProperty("Family households: Other family: Female householder, no husband present")]
		public AcsPair FamilyOtherFemaleNoHusband { get; set; }

		/// <summary>
		/// Family households: Other family: Male householder, no wife present
		/// </summary>
		[JsonProperty("Family households: Other family: Male householder, no wife present")]
		public AcsPair FamilyOtherMaleNoWife { get; set; }

		public AcsDataMeta Meta { get; set; }

		/// <summary>
		/// Nonfamily households
		/// </summary>
		[JsonProperty("Nonfamily households")]
		public AcsPair NonFamily { get; set; }

		/// <summary>
		/// Nonfamily households: Householder living alone
		/// </summary>
		[JsonProperty("Nonfamily households: Householder living alone")]
		public AcsPair NonFamilyLivingAlone { get; set; }

		/// <summary>
		/// Nonfamily households: Householder not living alone
		/// </summary>
		[JsonProperty("Nonfamily households: Householder not living alone")]
		public AcsPair NonFamilyNotLivingAlone { get; set; }

		public AcsPair Total { get; set; }
	}
}