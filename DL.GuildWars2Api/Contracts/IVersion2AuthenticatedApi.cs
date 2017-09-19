using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts
{
    public interface IVersion2AuthenticatedApi :
        IAuthenticatedCharacterApi,
        IAuthenticatedGuildApi
    {
        string ApiKey { get; set; }
        bool HasKey { get; }

        #region General / Misc

        Task<Account> GetAccountAsync();
        Task<TokenInfo> GetTokenInfoAsync();
        Task<WalletCurrency[]> GetWalletAsync();

        #endregion

        #region Dungeons

        Task<string[]> GetDungeonsAsync();

        #endregion

        #region Raids

        Task<string[]> GetRaidsAsync();

        #endregion
    }
}
