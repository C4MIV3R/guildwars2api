using DL.GuildWars2Api.Models.V1;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V1
{
    public interface IGuildApi
    {
        Task<Guild> GetGuildByIdAsync(string guildId);
        Task<Guild> GetGuildByNameAsync(string guildName);
    }
}
