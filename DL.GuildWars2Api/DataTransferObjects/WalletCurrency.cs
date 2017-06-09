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

        public string AmountDisplay
        {
            get
            {
                var amount = this.Amount.ToString();

                if (this.CurrencyId == 1)
                {
                    
                    var copperIndex = amount.Length - 2;
                    var silverIndex = amount.Length - 4;
                    var copper = amount.Substring(copperIndex);
                    var silver = amount.Substring(silverIndex, 2);
                    var gold = amount.Substring(0, silverIndex);
                    return $"{gold}g {silver}s {copper}c";
                }

                return amount;
            }
        }
    }
}
