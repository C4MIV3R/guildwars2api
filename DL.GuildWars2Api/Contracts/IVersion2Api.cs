using DL.GuildWars2Api.Models.V2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts
{
    public interface IVersion2Api
    {
        IVersion2AuthenticatedApi Authenticated { get; set; }

        Task<Currency> GetCurrencyAsync(int currencyId);
        Task<Currency[]> GetCurrenciesAsync();

        #region Dungeons

        Task<string[]> GetDungeonsAsync();
        Task<Dungeon> GetDungeonsAsync(string dungeonId);
        Task<Dungeon[]> GetDungeonsAsync(string[] dungeonIdList);

        #endregion

        #region Guilds   

        Task<string[]> GetGuildSearchAsync(string name);
        Task<GuildPermission[]> GetGuildPermissionByIdAsync(IEnumerable<string> ids);
        Task<GuildUpgrade> GetGuildUpgradeByIdAsync(int id);
        Task<GuildUpgrade[]> GetGuildUpgradeByIdAsync(IEnumerable<int> idList);

        #endregion

        #region Items

        Task<Item[]> GetItemByIdAsync(IEnumerable<int> idList);
        Task<Item> GetItemByIdAsync(int id);

        #endregion

        #region Raids

        Task<string[]> GetRaidsAsync();
        Task<Raid> GetRaidsAsync(string dungeonId);
        Task<Raid[]> GetRaidsAsync(string[] dungeonIdList);

        #endregion

        #region Skins

        Task<Skin[]> GetSkinByIdAsync(IEnumerable<int> idList);
        Task<Skin> GetSkinByIdAsync(int id);

        #endregion

        #region Worlds

        Task<World[]> GetWorldsAsync();
        Task<World> GetWorldAsync(int worldId);

        #endregion
    }
}
