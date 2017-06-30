using DL.GuildWars2Api.Models.V1;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts
{
    public interface IVersion1Api
    {
        #region Guilds

        Task<Guild> GetGuildByIdAsync(string guildId);
        Task<Guild> GetGuildByNameAsync(string guildName);

        #endregion
    }
}
