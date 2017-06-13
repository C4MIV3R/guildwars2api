using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildInventory
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
    }
}
