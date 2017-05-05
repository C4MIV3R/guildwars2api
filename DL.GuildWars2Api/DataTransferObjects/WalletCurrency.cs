using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WalletCurrency
    {
        [JsonProperty(PropertyName = "id")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "value")]
        public int Amount { get; set; }
    }
}
