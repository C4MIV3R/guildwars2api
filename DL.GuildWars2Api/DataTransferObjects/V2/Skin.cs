using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Skin
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "flags")]
        public string[] Flags { get; set; }

        [JsonProperty(PropertyName = "restrictions")]
        public string[] Restrictions { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string IconUrl { get; set; }
    }
}
