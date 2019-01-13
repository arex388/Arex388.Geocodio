using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class Census {
		/// <summary>
		/// The full 4-digit block code that the location belongs to. This is the smallest geographical unit that the U.S. Census Bureau provides statistical data for.
		/// </summary>
		[JsonProperty("block_code")]
		public string BlockCode { get; set; }

		/// <summary>
		/// The single-digit group number for the block
		/// </summary>
		[JsonProperty("block_group")]
		public string BlockGroup { get; set; }

		[JsonProperty("combined_statistical_data")]
		public CensusArea CombinedStatisticalArea { get; set; }

		/// <summary>
		/// The five-digit county FIPS code. The two first digits represents the state. A full list of US counties is available on Wikipedia
		/// </summary>
		[JsonProperty("county_fips")]
		public string CountyFipsCode { get; set; }

		/// <summary>
		/// The full 15-digit fips code, consisting of the county fips, tract code and block code
		/// </summary>
		[JsonProperty("full_fips")]
		public string FullFipsCode { get; set; }

		[JsonProperty("metro_micro_statistical_area")]
		public CensusArea MetroMicroStatisticalArea { get; set; }

		/// <summary>
		/// The 7-digit place FIPS code. A place is defined as a city or other census designated area. A full list of ANSI codes is available from the U.S. Census Bureau
		/// </summary>
		[JsonProperty("place_fips")]
		public string PlaceFipsCode { get; set; }

		/// <summary>
		/// The two-digit state FIPS code. A full list is available on Wikipedia
		/// </summary>
		[JsonProperty("state_fips")]
		public string StateFipsCode { get; set; }

		/// <summary>
		///	The 6-digit census tract code. This is a subdivision of a county, used for statistical purposes.
		/// </summary>
		[JsonProperty("tract_code")]
		public string TractCode { get; set; }

		/// <summary>
		/// The full year that the Census data belongs to (The U.S. Census Bureau might make slight boundary changes from year to year)
		/// </summary>
		[JsonProperty("census_year")]
		public short Year { get; set; }
	}
}