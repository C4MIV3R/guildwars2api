using DL.GuildWars2Api.Models.V2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IGuildApi
    {
        Task<string[]> GetGuildSearchAsync(string name);
        Task<GuildPermission[]> GetGuildPermissionByIdAsync(IEnumerable<string> ids);
        Task<GuildUpgrade> GetGuildUpgradeByIdAsync(int id);
        Task<GuildUpgrade[]> GetGuildUpgradeByIdAsync(IEnumerable<int> idList);
    }
}
