using Newtonsoft.Json;

namespace Arex388.Geocodio {
	public sealed class AcsHousing {
		/// <summary>
		/// Number of housing units
		/// </summary>
		[JsonProperty("Number of housing units")]
		public AcsHousingCount Count { get; set; }

		/// <summary>
		/// Occupancy status
		/// </summary>
		[JsonProperty("Occupancy status")]
		public AcsHousingOccupancy Occupancy { get; set; }

		/// <summary>
		/// Ownership of occupied units
		/// </summary>
		[JsonProperty("Ownership of occupied units")]
		public AcsHousingOwnership Ownership { get; set; }

		/// <summary>
		/// Median value of owner-occupied housing units
		/// </summary>
		[JsonProperty("Median value of owner-occupied housing units")]
		public AcsHousingOwnedMedianValue OwnedMedianValue { get; set; }

		/// <summary>
		/// Value of owner-occupied housing units
		/// </summary>
		[JsonProperty("Value of owner-occupied housing units")]
		public AcsHousingOwnedValues OwnedValues { get; set; }

		/// <summary>
		/// Units in structure
		/// </summary>
		[JsonProperty("Units in structure")]
		public AcsHousingUnits Units { get; set; }
	}
}