using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class DungeonApi : IDungeonApi
    {
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
    }
}
