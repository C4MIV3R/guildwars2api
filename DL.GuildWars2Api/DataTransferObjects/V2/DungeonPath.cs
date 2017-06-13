using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DungeonPath
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
