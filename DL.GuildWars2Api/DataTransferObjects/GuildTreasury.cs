using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildTreasury
    {
        [JsonProperty(PropertyName = "item_id")]
        public int ItemId { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "needed_by")]
        public NeededBy[] NeededBy { get; set; }
    }
}
