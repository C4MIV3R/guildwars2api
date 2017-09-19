using DL.GuildWars2Api.Models.V2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IItemApi
    {
        Task<Item[]> GetItemByIdAsync(IEnumerable<int> idList);
        Task<Item> GetItemByIdAsync(int id);
    }
}
