using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api
{
    public class Version2Facade
    {
        public Version2Facade()
        {
            this.Authenticated = new Version2AuthenticatedFacade();
        }

        public Version2Facade(string apiKey)
        {
            this.Authenticated = new Version2AuthenticatedFacade { ApiKey = apiKey };
        }

        public Version2AuthenticatedFacade Authenticated { get; set; }

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

        #region Dungeons

        public async Task<string[]> GetDungeonsAsync()
        {
            const string url = "v2/dungeons";
            return await new HttpClientHelper().GetStringAsync<string[]>(url);
        }

        public async Task<Dungeon> GetDungeonsAsync(string dungeonId)
        {
            string url = $"v2/dungeons/{dungeonId}";
            return await new HttpClientHelper().GetStringAsync<Dungeon>(url);
        }

        public async Task<Dungeon[]> GetDungeonsAsync(string[] dungeonIdList)
        {
            var list = string.Join(",", dungeonIdList);
            var url = $"v2/dungeons?ids={list}";
            return await new HttpClientHelper().GetStringAsync<Dungeon[]>(url);
        }

        #endregion

        #region Guilds   

        public async Task<string[]> GetGuildSearchAsync(string name)
        {
            var guildName = name.Replace(" ", "%20");
            var url = $"v2/guild/search?name={guildName}";
            return await new HttpClientHelper().GetStringAsync<string[]>(url);
        }
                
        public async Task<GuildPermission[]> GetGuildPermissionByIdAsync(IEnumerable<string> ids)
        {
            var list = string.Join(",", ids.Select(x => x).ToArray());
            var url = $"v2/guild/permissions?ids={list}";
            return await new HttpClientHelper().GetStringAsync<GuildPermission[]>(url);
        }

        public async Task<GuildUpgrade> GetGuildUpgradeByIdAsync(int id)
        {
            var url = $"v2/guild/upgrades/{id}";
            return await new HttpClientHelper().GetStringAsync<GuildUpgrade>(url);
        }

        public async Task<GuildUpgrade[]> GetGuildUpgradeByIdAsync(IEnumerable<int> idList)
        {
            var list = string.Join(",", idList.Select(x => x.ToString()).ToArray());
            var url = $"v2/guild/upgrades?ids={list}";
            return await new HttpClientHelper().GetStringAsync<GuildUpgrade[]>(url);
        }

        #endregion

        #region Items

        public async Task<Item[]> GetItemByIdAsync(IEnumerable<int> idList)
        {
            var list = string.Join(",", idList.Select(x => x.ToString()).ToArray());
            var url = $"v2/items?ids={list}";
            return await new HttpClientHelper().GetStringAsync<Item[]>(url);
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            var url = $"v2/items/{id}";
            return await new HttpClientHelper().GetStringAsync<Item>(url);
        }

        #endregion

        #region Raids

        public async Task<string[]> GetRaidsAsync()
        {
            const string url = "v2/raids";
            return await new HttpClientHelper().GetStringAsync<string[]>(url);
        }

        public async Task<Raid> GetRaidsAsync(string dungeonId)
        {
            string url = $"v2/raids/{dungeonId}";
            return await new HttpClientHelper().GetStringAsync<Raid>(url);
        }

        public async Task<Raid[]> GetRaidsAsync(string[] dungeonIdList)
        {
            var list = string.Join(",", dungeonIdList);
            var url = $"v2/raids?ids={list}";
            return await new HttpClientHelper().GetStringAsync<Raid[]>(url);
        }

        #endregion

        #region Skins

        public async Task<Skin[]> GetSkinByIdAsync(IEnumerable<int> idList)
        {
            var list = string.Join(",", idList.Select(x => x.ToString()).ToArray());
            var url = $"v2/skins?ids={list}";
            return await new HttpClientHelper().GetStringAsync<Skin[]>(url);
        }

        public async Task<Skin> GetSkinByIdAsync(int id)
        {
            var url = $"v2/skins/{id}";
            return await new HttpClientHelper().GetStringAsync<Skin>(url);
        }

        #endregion

        #region Worlds

        public async Task<World[]> GetWorldsAsync()
        {
            const string url = "v2/worlds?ids=all";
            return await new HttpClientHelper().GetStringAsync<World[]>(url);
        }

        public async Task<World> GetWorldAsync(int worldId)
        {
            var url = $"v2/worlds?ids={worldId}";
            var worlds = await new HttpClientHelper().GetStringAsync<World[]>(url);
            return worlds[0];
        }

        #endregion
    }
}
