using Newtonsoft.Json;

namespace Arex388.Geocodio; 

public sealed class AcsHousingOwnership {
    public AcsDataMeta Meta { get; set; }

    /// <summary>
    /// Owner occupied
    /// </summary>
    [JsonProperty("Owner occupied")]
    public AcsPair OwnerOccupied { get; set; }

    /// <summary>
    /// Renter occupied
    /// </summary>
    [JsonProperty("Renter occupied")]
    public AcsPair RenterOccupied { get; set; }
}