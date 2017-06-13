using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ItemDetail
    {
        [JsonProperty(PropertyName = "no_sell_or_sort")]
        public bool NoSellOrSort { get; set; }

        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
    }
}
