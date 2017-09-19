using DL.GuildWars2Api.Models.V2;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IWorldApi
    {
        Task<World[]> GetWorldsAsync();
        Task<World> GetWorldAsync(int worldId);
    }
}
