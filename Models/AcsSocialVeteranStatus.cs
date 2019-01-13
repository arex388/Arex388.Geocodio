using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsSocialVeteranStatus {
		public AcsPair Female { get; set; }

		/// <summary>
		/// Female: Veteran
		/// </summary>
		[JsonProperty("Female: Veteran")]
		public AcsPair FemaleVeteran { get; set; }

		/// <summary>
		/// Female: Nonveteran
		/// </summary>
		[JsonProperty("Female: Nonveteran")]
		public AcsPair FemaleNonVeteran { get; set; }

		public AcsPair Male { get; set; }

		/// <summary>
		/// Male: Veteran
		/// </summary>
		[JsonProperty("Male: Veteran")]
		public AcsPair MaleVeteran { get; set; }

		/// <summary>
		/// Male: Nonveteran
		/// </summary>
		[JsonProperty("Male: Nonveteran")]
		public AcsPair MaleNonVeteran { get; set; }

		public AcsDataMeta Meta { get; set; }
		public AcsPair NonVeteran { get; set; }
		public AcsPair Total { get; set; }
		public AcsPair Veteran { get; set; }
	}
}