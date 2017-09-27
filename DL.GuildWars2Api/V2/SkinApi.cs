using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class SkinApi : ISkinApi
    {
        public async Task<Skin[]> GetSkinByIdAsync(IEnumerable<int> idList)
        {
            var list = string.Join(",", idList.Select(x => x.ToString()).ToArray());
            var url = $"v2/skins?ids={list}";
            return await new HttpClientHelper().GetStringAsync<Skin[]>(url);
        }

        public async Task<Skin> GetSkinByIdAsync(int id)
        {
            var url = $"v2/skins/{id}";
            return await new HttpClientHelper().GetStringAsync<Skin>(url);
        }
    }
}
