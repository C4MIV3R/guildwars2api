using System.Threading.Tasks;
using DL.GuildWars2Api.DataTransferObjects.V1;

namespace DL.GuildWars2Api
{
    public class Version1Facade
    {
        #region Guilds

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

        #endregion
    }
}
