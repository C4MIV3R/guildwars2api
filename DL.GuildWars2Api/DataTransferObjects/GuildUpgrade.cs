using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildUpgrade
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string PropertyName { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "build_time")]
        public int BuildTime { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string UpgradeType { get; set; }

        [JsonProperty(PropertyName = "required_level")]
        public int RequiredLevel { get; set; }

        [JsonProperty(PropertyName = "experience")]
        public int Experience { get; set; }

        [JsonProperty(PropertyName = "prerequisites")]
        public int[] Prerequisites { get; set; }

        [JsonProperty(PropertyName = "bag_max_items")]
        public int BagMaxItems { get; set; }

        [JsonProperty(PropertyName = "bag_max_coins")]
        public int BagMaxCoins { get; set; }

        [JsonProperty(PropertyName = "costs")]
        public GuildUpgradeCost[] Costs { get; set; }
    }
}
