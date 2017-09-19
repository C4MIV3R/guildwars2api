using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IDungeonApi
    {
        Task<string[]> GetDungeonsAsync();
        Task<Dungeon> GetDungeonsAsync(string dungeonId);
        Task<Dungeon[]> GetDungeonsAsync(string[] dungeonIdList);
    }
}
