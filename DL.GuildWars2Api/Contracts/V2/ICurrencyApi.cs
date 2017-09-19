using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface ICurrencyApi
    {
        Task<Currency> GetCurrencyAsync(int currencyId);
        Task<Currency[]> GetCurrenciesAsync();
    }
}
