using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class ItemApi : IItemApi
    {
        public async Task<Item[]> GetItemByIdAsync(IEnumerable<int> idList)
        {
            var list = string.Join(",", idList.Select(x => x.ToString()).ToArray());
            var url = $"v2/items?ids={list}";
            return await new HttpClientHelper().GetStringAsync<Item[]>(url);
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            var url = $"v2/items/{id}";
            return await new HttpClientHelper().GetStringAsync<Item>(url);
        }
    }
}
