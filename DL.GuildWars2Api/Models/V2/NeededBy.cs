using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class NeededBy
    {
        [JsonProperty(PropertyName = "upgrade_id")]
        public int UpgradeId { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
    }
}
