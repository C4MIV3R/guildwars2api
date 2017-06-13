using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V1
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Guild
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "guild_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "emblem")]
        public GuildEmblem Emblem { get; set; }

        public string FullName => $"{this.Name} [{this.Tag}]";
    }
}
