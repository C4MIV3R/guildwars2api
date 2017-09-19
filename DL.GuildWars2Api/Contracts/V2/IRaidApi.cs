using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IRaidApi
    {
        Task<string[]> GetRaidsAsync();
        Task<Raid> GetRaidsAsync(string dungeonId);
        Task<Raid[]> GetRaidsAsync(string[] dungeonIdList);
    }
}
