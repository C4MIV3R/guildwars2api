using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V1;
using DL.GuildWars2Api.Models.V1;

namespace DL.GuildWars2Api.V1
{
    internal class GuildApi : IGuildApi
    {
        public async Task<Guild> GetGuildByIdAsync(string guildId)
        {
            var url = $"v1/guild_details.json?guild_id={guildId}";
            return await new HttpClientHelper().GetStringAsync<Guild>(url);
        }

        public async Task<Guild> GetGuildByNameAsync(string guildName)
        {
            guildName = guildName.Replace(" ", "%20");
            var url = $"v1/guild_details.json?guild_name={guildName}";
            return await new HttpClientHelper().GetStringAsync<Guild>(url);
        }
    }
}
