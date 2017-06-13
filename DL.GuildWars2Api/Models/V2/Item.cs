using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Item
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }

        [JsonProperty(PropertyName = "vendor_value")]
        public int VendorValue { get; set; }

        [JsonProperty(PropertyName = "game_types")]
        public string[] GameTypes { get; set; }

        [JsonProperty(PropertyName = "flags")]
        public string[] Flags { get; set; }

        [JsonProperty(PropertyName = "restrictions")]
        public string[] Restrictions { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "chat_link")]
        public string ChatLink { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        [JsonProperty(PropertyName = "details")]
        public ItemDetail Details { get; set; }
    }
}
