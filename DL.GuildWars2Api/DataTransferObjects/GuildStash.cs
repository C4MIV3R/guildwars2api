using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildStash
    {
        [JsonProperty(PropertyName = "upgrade_id")]
        public int UpgradeId { get; set; }

        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        [JsonProperty(PropertyName = "coins")]
        public int Coins { get; set; }

        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        [JsonProperty(PropertyName = "inventory")]
        public GuildInventory[] Inventory { get; set; }
    }
}
