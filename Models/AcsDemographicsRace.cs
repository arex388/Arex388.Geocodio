using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsDemographicsRace {
		public AcsDataMeta Meta { get; set; }

		/// <summary>
		/// Not Hispanic or Latino
		/// </summary>
		[JsonProperty("Not Hispanic or Latino")]
		public AcsPair NotHispanicOrLatino { get; set; }

		/// <summary>
		/// Not Hispanic or Latino: White alone
		/// </summary>
		[JsonProperty("Not Hispanic or Latino: White alone")]
		public AcsPair NotHispanicOrLatinoWhiteAlone { get; set; }

		/// <summary>
		/// Not Hispanic or Latino: Black or African American alone
		/// </summary>
		[JsonProperty("Not Hispanic or Latino: Black or African American alone")]
		public AcsPair NotHispanicOrLatinoBlackOrAfricanAmaricanAlone { get; set; }

		/// <summary>
		/// Not Hispanic or Latino: American Indian and Alaska Native alone
		/// </summary>
		[JsonProperty("Not Hispanic or Latino: American Indian and Alaska Native alone")]
		public AcsPair NotHispanicOrLatinoAmericanIndianAndAlaskaNativeAlone { get; set; }

		/// <summary>
		/// Not Hispanic or Latino: Asian alone
		/// </summary>
		[JsonProperty("Not Hispanic or Latino: Asian alone")]
		public AcsPair NotHispanicOrLatinoAsianAlone { get; set; }

		/// <summary>
		/// Not Hispanic or Latino: Native Hawaiian and Other Pacific Islander alone
		/// </summary>
		[JsonProperty("Not Hispanic or Latino: Native Hawaiian and Other Pacific Islander alone")]
		public AcsPair NotHispanicOrLatinoNativeHawaiianAndOtherPacificIslanderAlone { get; set; }

		/// <summary>
		/// Not Hispanic or Latino: Some other race alone
		/// </summary>
		[JsonProperty("Not Hispanic or Latino: Some other race alone")]
		public AcsPair NotHispanicOrLatinoOtherAlone { get; set; }

		/// <summary>
		/// Two or more races
		/// </summary>
		[JsonProperty("Two or more races")]
		public AcsPair TwoOrMore { get; set; }

		/// <summary>
		/// Two or more races: Two races including Some other race
		/// </summary>
		[JsonProperty("Two or more races: Two races including Some other race")]
		public AcsPair TwoOrMoreTwoIncludingOther { get; set; }

		/// <summary>
		/// Two or more races: Two races excluding Some other race, and three or more races
		/// </summary>
		[JsonProperty("Two or more races: Two races excluding Some other race, and three or more races")]
		public AcsPair TwoOrMoreTwoExcludingOtherThreeOrMore { get; set; }

		/// <summary>
		/// Hispanic or Latino
		/// </summary>
		[JsonProperty("Hispanic or Latino")]
		public AcsPair HispanicOrLatino { get; set; }

		/// <summary>
		/// Hispanic or Latino: White alone
		/// </summary>
		[JsonProperty("Hispanic or Latino: White alone")]
		public AcsPair HispanicOrLatinoWhiteAlone { get; set; }

		/// <summary>
		/// Hispanic or Latino: Black or African American alone
		/// </summary>
		[JsonProperty("Hispanic or Latino: Black or African American alone")]
		public AcsPair HispanicOrLatinoBlackOrAfricanAmericanAlone { get; set; }

		/// <summary>
		/// Hispanic or Latino: American Indian and Alaska Native alone
		/// </summary>
		[JsonProperty("Hispanic or Latino: American Indian and Alaska Native alone")]
		public AcsPair HispanicOrLatinoAmericanIndianAndAlaskaNativeAlone { get; set; }

		/// <summary>
		/// Hispanic or Latino: Asian alone
		/// </summary>
		[JsonProperty("Hispanic or Latino: Asian alone")]
		public AcsPair HispanicOrLatinoAsianAlone { get; set; }

		/// <summary>
		/// Hispanic or Latino: Native Hawaiian and Other Pacific Islander alone
		/// </summary>
		[JsonProperty("Hispanic or Latino: Native Hawaiian and Other Pacific Islander alone")]
		public AcsPair HispanicOrLatinoNativeHawaiianAndOtherPacificIslanderAlone { get; set; }

		/// <summary>
		/// Hispanic or Latino: Some other race alone
		/// </summary>
		[JsonProperty("Hispanic or Latino: Some other race alone")]
		public AcsPair HispanicOrLatinoOtherAlone { get; set; }

		public AcsPair Total { get; set; }
	}
}