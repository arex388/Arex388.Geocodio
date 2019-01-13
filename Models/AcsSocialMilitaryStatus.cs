using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsSocialMilitaryStatus {
		public AcsDataMeta Meta { get; set; }
		public AcsPair Total { get; set; }

		/// <summary>
		/// Gulf War (9/2001 or later), no Gulf War (8/1990 to 8/2001), no Vietnam Era
		/// </summary>
		[JsonProperty("Gulf War (9/2001 or later), no Gulf War (8/1990 to 8/2001), no Vietnam Era")]
		public AcsPair Gulf2001NoGulf1990NoVietnam { get; set; }

		/// <summary>
		/// Gulf War (9/2001 or later) and Gulf War (8/1990 to 8/2001), no Vietnam Era
		/// </summary>
		[JsonProperty("Gulf War (9/2001 or later) and Gulf War (8/1990 to 8/2001), no Vietnam Era")]
		public AcsPair Gulf2001AndGulf1990NoVietnam { get; set; }

		/// <summary>
		/// Gulf War (9/2001 or later), and Gulf War (8/1990 to 8/2001), and Vietnam Era
		/// </summary>
		[JsonProperty("Gulf War (9/2001 or later), and Gulf War (8/1990 to 8/2001), and Vietnam Era")]
		public AcsPair Gulf2001AndGulf1990AndVietnam { get; set; }

		/// <summary>
		/// Gulf War (8/1990 to 8/2001), no Vietnam Era
		/// </summary>
		[JsonProperty("Gulf War (8/1990 to 8/2001), no Vietnam Era")]
		public AcsPair Gulf1990To2001NoVietnam { get; set; }

		/// <summary>
		/// Gulf War (8/1990 to 8/2001) and Vietnam Era
		/// </summary>
		[JsonProperty("Gulf War (8/1990 to 8/2001) and Vietnam Era")]
		public AcsPair Gulf1990To2001AndVietnam { get; set; }

		/// <summary>
		/// Vietnam Era, no Korean War, no World War II
		/// </summary>
		[JsonProperty("Vietnam Era, no Korean War, no World War II")]
		public AcsPair VietnamNoKoreaNoWw2 { get; set; }

		/// <summary>
		/// Vietnam Era and Korean War, no World War II
		/// </summary>
		[JsonProperty("Vietnam Era and Korean War, no World War II")]
		public AcsPair VietnamAndKoreaNoWw2 { get; set; }

		/// <summary>
		/// Vietnam Era and Korean War and World War II
		/// </summary>
		[JsonProperty("Vietnam Era and Korean War and World War II")]
		public AcsPair VietnamAndKoreaAndWw2 { get; set; }

		/// <summary>
		/// Korean War, no Vietnam Era, no World War II
		/// </summary>
		[JsonProperty("Korean War, no Vietnam Era, no World War II")]
		public AcsPair KoreaNoVietnamNoWw2 { get; set; }

		/// <summary>
		/// Korean War and World War II, no Vietnam Era
		/// </summary>
		[JsonProperty("Korean War and World War II, no Vietnam Era")]
		public AcsPair KoreaAndWw2NoVietnam { get; set; }

		/// <summary>
		/// World War II, no Korean War, no Vietnam Era
		/// </summary>
		[JsonProperty("World War II, no Korean War, no Vietnam Era")]
		public AcsPair Ww2NoKoreaNoVietnam { get; set; }

		/// <summary>
		/// Between Gulf War and Vietnam Era only
		/// </summary>
		[JsonProperty("Between Gulf War and Vietnam Era only")]
		public AcsPair BetweenGulfAndVietnam { get; set; }

		/// <summary>
		/// Between Vietnam Era and Korean War only
		/// </summary>
		[JsonProperty("Between Vietnam Era and Korean War only")]
		public AcsPair BetweenVietnamAndKorea { get; set; }

		/// <summary>
		/// Between Korean War and World War II only
		/// </summary>
		[JsonProperty("Between Korean War and World War II only")]
		public AcsPair BetweenKoreaAndWw2 { get; set; }

		/// <summary>
		/// Pre-World War II only
		/// </summary>
		[JsonProperty("Pre-World War II only")]
		public AcsPair PreWw2 { get; set; }
	}
}