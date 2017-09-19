using DL.GuildWars2Api.Models.V2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface ISkinApi
    {
        Task<Skin[]> GetSkinByIdAsync(IEnumerable<int> idList);
        Task<Skin> GetSkinByIdAsync(int id);
    }
}
