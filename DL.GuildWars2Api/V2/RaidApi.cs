using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class RaidApi : IRaidApi
    {
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
    }
}
