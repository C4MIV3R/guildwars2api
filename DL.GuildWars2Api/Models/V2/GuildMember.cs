using System;
using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildMember
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "joined")]
        public string Joined { get; set; }

        public DateTime? JoinedDatestamp => string.IsNullOrWhiteSpace(this.Joined) 
            ? (DateTime?)null 
            : DateTime.Parse(this.Joined);

        public string JoinedDisplay => string.IsNullOrWhiteSpace(this.Joined) 
            ? "Unknown" 
            : DateTime.Parse(this.Joined).ToLocalTime().ToString();
    }
}
