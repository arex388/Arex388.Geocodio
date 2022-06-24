namespace Arex388.Geocodio; 

public sealed class AcsHousingOccupancy {
    public AcsDataMeta Meta { get; set; }
    public AcsPair Occupied { get; set; }
    public AcsPair Vacant { get; set; }
}