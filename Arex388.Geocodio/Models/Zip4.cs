using Newtonsoft.Json;
using System.Collections.Generic;

namespace Arex388.Geocodio {
    public sealed class Zip4 {
        [JsonProperty("building_or_firm_name")]
        public string BuildingOrFirmName { get; set; }

        [JsonProperty("carrier_route")]
        public Zip4CarrierRoute CarrierRoute { get; set; }

        [JsonProperty("city_delivery")]
        public bool IsDeliverableToByCity { get; set; }

        [JsonProperty("exact_match")]
        public bool IsExactMatch { get; set; }

        [JsonProperty("valid_delivery_area")]
        public bool IsValidDeliveryArea { get; set; }

        [JsonProperty("facility_code")]
        public Zip4Item FacilityCode { get; set; }

        [JsonProperty("government_building")]
        public string GovernmentBuilding { get; set; }

        public IEnumerable<short> Plus4 { get; set; }

        [JsonProperty("record_type")]
        public Zip4Item RecordType { get; set; }

        public IEnumerable<string> Zip9 { get; set; }
    }
}