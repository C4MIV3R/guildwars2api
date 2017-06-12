using System.Collections.Generic;
using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects.V1
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildEmblem
    {
        [JsonProperty(PropertyName = "background_id")]
        public int BackgroundId { get; set; }

        [JsonProperty(PropertyName = "foreground_id")]
        public int ForegroundId { get; set; }

        [JsonProperty(PropertyName = "flags")]
        public List<object> Flags { get; set; }

        [JsonProperty(PropertyName = "background_color_id")]
        public int BackgroundColorId { get; set; }

        [JsonProperty(PropertyName = "foreground_primary_color_id")]
        public int ForegroundPrimaryColorId { get; set; }

        [JsonProperty(PropertyName = "foreground_secondary_color_id")]
        public int ForegroundSecondaryColorId { get; set; }
    }
}
