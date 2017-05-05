using Newtonsoft.Json;
using System.Collections.Generic;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Account
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "world")]
        public int WorldId { get; set; }

        [JsonProperty(PropertyName = "guilds")]
        public List<string> GuildIds { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        [JsonProperty(PropertyName = "fractal_level")]
        public int FractalLevel { get; set; }
    }
}
