using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
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
