namespace Arex388.Geocodio {
	public sealed class Acs {
		public AcsDemographics Demographics { get; set; }
		public AcsEconomics Economics { get; set; }
		public AcsFamilies Families { get; set; }
		public AcsHousing Housing { get; set; }
		public AcsMeta Meta { get; set; }
		public AcsSocial Social { get; set; }
	}
}