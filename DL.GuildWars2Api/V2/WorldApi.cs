using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class WorldApi : IWorldApi
    {
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
    }
}
