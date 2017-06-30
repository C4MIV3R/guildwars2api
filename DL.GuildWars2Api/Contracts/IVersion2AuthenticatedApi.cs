using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts
{
    public interface IVersion2AuthenticatedApi
    {
        string ApiKey { get; set; }
        bool HasKey { get; }

        #region General / Misc

        Task<Account> GetAccountAsync();
        Task<TokenInfo> GetTokenInfoAsync();
        Task<WalletCurrency[]> GetWalletAsync();

        #endregion

        #region Characters

        Task<string[]> GetCharactersAsync();
        Task<Character> GetCharacterAsync(string characterName);

        #endregion

        #region Dungeons

        Task<string[]> GetDungeonsAsync();

        #endregion

        #region Guilds

        Task<Guild> GetGuildAsync(string guildId);
        Task<GuildLog[]> GetGuildLogAsync(string guildId);
        Task<GuildMember[]> GetGuildMemberAsync(string guildId);
        Task<GuildRank[]> GetGuildRanksAsync(string guildId);
        Task<GuildStash[]> GetGuildStashAsync(string guildId);
        Task<GuildTreasury[]> GetGuildTreasuryAsync(string guildId);

        #endregion

        #region Raids

        Task<string[]> GetRaidsAsync();

        #endregion
    }
}
