using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsFamiliesMaritalStatus {
		public AcsPair Male { get; set; }

		/// <summary>
		/// Male: Never married
		/// </summary>
		[JsonProperty("Male: Never married")]
		public AcsPair MaleNeverMarried { get; set; }

		/// <summary>
		/// Now married
		/// </summary>
		[JsonProperty("Now married")]
		public AcsPair NowMarried { get; set; }

		/// <summary>
		/// Now married: Married, spouse present
		/// </summary>
		[JsonProperty("Now married: Married, spouse present")]
		public AcsPair NowMarriedSpousePresent { get; set; }

		/// <summary>
		/// Married, spouse absent
		/// </summary>
		[JsonProperty("Married, spouse absent")]
		public AcsPair MarriedSpouseAbsent { get; set; }

		/// <summary>
		/// Married, spouse absent: Separated
		/// </summary>
		[JsonProperty("Married, spouse absent: Separated")]
		public AcsPair MarriedSpouseAbsentSeparated { get; set; }

		/// <summary>
		/// Married, spouse absent: Other
		/// </summary>
		[JsonProperty("Married, spouse absent: Other")]
		public AcsPair MarriedSpouseAbsentOther { get; set; }

		/// <summary>
		/// Married, spouse absent: Widowed
		/// </summary>
		[JsonProperty("Married, spouse absent: Widowed")]
		public AcsPair MarriedSpouseAbsentWidowed { get; set; }

		/// <summary>
		/// Married, spouse absent: Divorced
		/// </summary>
		[JsonProperty("Married, spouse absent: Divorced")]
		public AcsPair MarriedSpouseAbsentDivorced { get; set; }

		public AcsPair Female { get; set; }

		/// <summary>
		/// Female: Never married
		/// </summary>
		[JsonProperty("Female: Never married")]
		public AcsPair FemaleNeverMarried { get; set; }

		public AcsDataMeta Meta { get; set; }
	}
}