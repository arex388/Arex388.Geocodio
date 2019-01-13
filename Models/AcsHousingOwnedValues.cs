using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsHousingOwnedValues {
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
		/// $40,000 to $49,999
		/// </summary>
		[JsonProperty("$40,000 to $49,999")]
		public AcsPair Range40KTo50K { get; set; }

		/// <summary>
		/// $50,000 to $59,999
		/// </summary>
		[JsonProperty("$50,000 to $59,999")]
		public AcsPair Range50KTo60K { get; set; }

		/// <summary>
		/// $60,000 to $69,999
		/// </summary>
		[JsonProperty("$60,000 to $69,999")]
		public AcsPair Range60KTo70K { get; set; }

		/// <summary>
		/// $70,000 to $79,999
		/// </summary>
		[JsonProperty("$70,000 to $79,999")]
		public AcsPair Range70KTo80K { get; set; }

		/// <summary>
		/// $80,000 to $89,999
		/// </summary>
		[JsonProperty("$80,000 to $89,999")]
		public AcsPair Range80KTo90K { get; set; }

		/// <summary>
		/// $90,000 to $99,999
		/// </summary>
		[JsonProperty("$90,000 to $99,999")]
		public AcsPair Range90KTo100K { get; set; }

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
		/// $150,000 to $174,999
		/// </summary>
		[JsonProperty("$150,000 to $174,999")]
		public AcsPair Range150KTo175K { get; set; }

		/// <summary>
		///	$175,000 to $199,999
		/// </summary>
		[JsonProperty("$175,000 to $199,999")]
		public AcsPair Range175KTo200K { get; set; }

		/// <summary>
		/// $200,000 to $249,999
		/// </summary>
		[JsonProperty("$200,000 to $249,999")]
		public AcsPair Range200KTo250K { get; set; }

		/// <summary>
		/// $250,000 to $299,999
		/// </summary>
		[JsonProperty("$250,000 to $299,999")]
		public AcsPair Range250KTo300K { get; set; }

		/// <summary>
		/// $300,000 to $399,999
		/// </summary>
		[JsonProperty("$300,000 to $399,999")]
		public AcsPair Range300KTo400K { get; set; }

		/// <summary>
		/// $400,000 to $499,999
		/// </summary>
		[JsonProperty("$400,000 to $499,999")]
		public AcsPair Range400KTo500K { get; set; }

		/// <summary>
		/// $500,000 to $749,999
		/// </summary>
		[JsonProperty("$500,000 to $749,999")]
		public AcsPair Range500KTo750K { get; set; }

		/// <summary>
		/// $750,000 to $999,999
		/// </summary>
		[JsonProperty("$750,000 to $999,999")]
		public AcsPair Range750KTo1M { get; set; }

		/// <summary>
		/// $1,000,000 to $1,499,999
		/// </summary>
		[JsonProperty("$1,000,000 to $1,499,999")]
		public AcsPair Range1MTo1M500K { get; set; }

		/// <summary>
		/// $1,500,000 to $1,999,999
		/// </summary>
		[JsonProperty("$1,500,000 to $1,999,999")]
		public AcsPair Range1M500KTo2M { get; set; }

		/// <summary>
		/// $2,000,000 or more
		/// </summary>
		[JsonProperty("$2,000,000 or more")]
		public AcsPair Range2MOrMore { get; set; }
	}
}