using Newtonsoft.Json;
using System.Collections.Generic;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Guild
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "influence")]
        public int Influence { get; set; }

        [JsonProperty(PropertyName = "aetherium")]
        public int Aetherium { get; set; }

        [JsonProperty(PropertyName = "resonance")]
        public int Resonance { get; set; }

        [JsonProperty(PropertyName = "favor")]
        public int Favor { get; set; }

        [JsonProperty(PropertyName = "member_count")]
        public int MemberCount { get; set; }

        [JsonProperty(PropertyName = "member_capacity")]
        public int MemberCapacity { get; set; }

        [JsonProperty(PropertyName = "motd")]
        public string MessageOfTheDay { get; set; }

        public IEnumerable<string> MessageOfTheDayLines => this.MessageOfTheDay.Split('\n');
    }
}
