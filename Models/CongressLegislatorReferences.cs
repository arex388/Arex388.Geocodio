using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class CongressLegislatorReferences {
		[JsonProperty("ballotpedia_id")]
		public string BallotpediaId { get; set; }

		[JsonProperty("bioguide_id")]
		public string BioGuideId { get; set; }

		[JsonProperty("cspan_id")]
		public string CspanId { get; set; }

		[JsonProperty("govtrack_id")]
		public string GovTrackId { get; set; }

		[JsonProperty("icpsr_id")]
		public string IcpsrId { get; set; }

		[JsonProperty("lis_id")]
		public string LisId { get; set; }

		[JsonProperty("opensecrets_id")]
		public string OpenSecretsId { get; set; }

		[JsonProperty("thomas_id")]
		public string ThomasId { get; set; }

		[JsonProperty("votesmart_id")]
		public string VoteSmartId { get; set; }

		[JsonProperty("washington_post_id")]
		public string WashingtonPostId { get; set; }

		[JsonProperty("wikipedia_id")]
		public string WikipediaId { get; set; }
	}
}