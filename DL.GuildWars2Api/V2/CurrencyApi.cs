using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class CurrencyApi : ICurrencyApi
    {
        public async Task<Currency> GetCurrencyAsync(int currencyId)
        {
            var url = $"v2/currencies/{currencyId}";
            return await new HttpClientHelper().GetStringAsync<Currency>(url);
        }

        public async Task<Currency[]> GetCurrenciesAsync()
        {
            var url = $"v2/currencies?ids=all";
            return await new HttpClientHelper().GetStringAsync<Currency[]>(url);
        }
    }
}
