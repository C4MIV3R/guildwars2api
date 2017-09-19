using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IAuthenticatedGuildApi
    {
        Task<Guild> GetGuildAsync(string guildId);
        Task<GuildLog[]> GetGuildLogAsync(string guildId);
        Task<GuildMember[]> GetGuildMemberAsync(string guildId);
        Task<GuildRank[]> GetGuildRanksAsync(string guildId);
        Task<GuildStash[]> GetGuildStashAsync(string guildId);
        Task<GuildTreasury[]> GetGuildTreasuryAsync(string guildId);
    }
}
