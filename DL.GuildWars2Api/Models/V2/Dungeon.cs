using Newtonsoft.Json;
using System.Collections.Generic;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Dungeon
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "paths")]
        public List<DungeonPath> Paths { get; set; }

    }
}
