using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsEconomicsHouseholdIncome {
		public AcsDataMeta Meta { get; set; }

		/// <summary>
		/// Less than $10,000
		/// </summary>
		[JsonProperty("Less than $10,000")]
		public AcsPair Range0KTo10K { get; set; }

		/// <summary>
		/// $10,000 to $14,999
		/// </summary>
		[JsonProperty("$10,000 to $14,999")]
		public AcsPair Range10KTo15K { get; set; }

		/// <summary>
		/// $15,000 to $19,999
		/// </summary>
		[JsonProperty("$15,000 to $19,999")]
		public AcsPair Range15KTo20K { get; set; }

		/// <summary>
		/// $20,000 to $24,999
		/// </summary>
		[JsonProperty("$20,000 to $24,999")]
		public AcsPair Range20KTo25K { get; set; }

		/// <summary>
		/// $25,000 to $29,999
		/// </summary>
		[JsonProperty("$25,000 to $29,999")]
		public AcsPair Range25KTo30K { get; set; }

		/// <summary>
		/// $30,000 to $34,999
		/// </summary>
		[JsonProperty("$30,000 to $34,999")]
		public AcsPair Range30KTo35K { get; set; }

		/// <summary>
		/// $35,000 to $39,999
		/// </summary>
		[JsonProperty("$35,000 to $39,999")]
		public AcsPair Range35KTo40K { get; set; }

		/// <summary>
		/// $40,000 to $44,999
		/// </summary>
		[JsonProperty("$40,000 to $44,999")]
		public AcsPair Range40KTo45K { get; set; }

		/// <summary>
		/// $45,000 to $49,999
		/// </summary>
		[JsonProperty("$45,000 to $49,999")]
		public AcsPair Range45KTo50K { get; set; }

		/// <summary>
		/// $50,000 to $59,999
		/// </summary>
		[JsonProperty("$50,000 to $59,999")]
		public AcsPair Range50KTo60K { get; set; }

		/// <summary>
		/// $60,000 to $74,999
		/// </summary>
		[JsonProperty("$60,000 to $74,999")]
		public AcsPair Range60KTo75K { get; set; }

		/// <summary>
		/// $75,000 to $99,999
		/// </summary>
		[JsonProperty("$75,000 to $99,999")]
		public AcsPair Range75KTo100K { get; set; }

		/// <summary>
		/// $100,000 to $124,999
		/// </summary>
		[JsonProperty("$100,000 to $124,999")]
		public AcsPair Range100KTo125K { get; set; }

		/// <summary>
		/// $125,000 to $149,999
		/// </summary>
		[JsonProperty("$125,000 to $149,999")]
		public AcsPair Range125KTo150K { get; set; }

		/// <summary>
		/// $150,000 to $199,999
		/// </summary>
		[JsonProperty("$150,000 to $199,999")]
		public AcsPair Range150KTo200K { get; set; }

		/// <summary>
		/// $200,000 or more
		/// </summary>
		[JsonProperty("$200,000 or more")]
		public AcsPair Range200KOrMore { get; set; }
	}
}