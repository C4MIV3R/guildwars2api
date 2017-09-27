using System.Threading.Tasks;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IAuthenticatedAccountApi : IAuthenticated
    {
        Task<Account> GetAccountAsync();
        Task<string[]> GetDungeonsAsync();
        Task<string[]> GetRaidsAsync();
        Task<TokenInfo> GetTokenInfoAsync();
        Task<WalletCurrency[]> GetWalletAsync();
    }
}
