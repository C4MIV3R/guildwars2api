using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class GuildApi : AuthenticatedBase, IAuthenticatedGuildApi
    {
        public GuildApi(string key)
            : base(key)
        {
        }

        #region IGuildApi Implementation

        public async Task<string[]> GetGuildSearchAsync(string name)
        {
            var guildName = name.Replace(" ", "%20");
            var url = $"v2/guild/search?name={guildName}";
            return await new HttpClientHelper().GetStringAsync<string[]>(url);
        }

        public async Task<GuildPermission[]> GetGuildPermissionByIdAsync(IEnumerable<string> ids)
        {
            var list = string.Join(",", ids.Select(x => x).ToArray());
            var url = $"v2/guild/permissions?ids={list}";
            return await new HttpClientHelper().GetStringAsync<GuildPermission[]>(url);
        }

        public async Task<GuildUpgrade> GetGuildUpgradeByIdAsync(int id)
        {
            var url = $"v2/guild/upgrades/{id}";
            return await new HttpClientHelper().GetStringAsync<GuildUpgrade>(url);
        }

        public async Task<GuildUpgrade[]> GetGuildUpgradeByIdAsync(IEnumerable<int> idList)
        {
            var list = string.Join(",", idList.Select(x => x.ToString()).ToArray());
            var url = $"v2/guild/upgrades?ids={list}";
            return await new HttpClientHelper().GetStringAsync<GuildUpgrade[]>(url);
        }

        #endregion

        #region IAuthenticatedGuildApi Implementation

        public async Task<Guild> GetGuildAsync(string guildId)
        {
            var url = $"v2/guild/{guildId}";
            return await new HttpClientHelper().GetStringAsync<Guild>(url, this.Key);
        }

        public async Task<GuildLog[]> GetGuildLogAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/log";
            return await new HttpClientHelper().GetStringAsync<GuildLog[]>(url, this.Key);
        }

        public async Task<GuildMember[]> GetGuildMemberAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/members";
            return await new HttpClientHelper().GetStringAsync<GuildMember[]>(url, this.Key);
        }

        public async Task<GuildRank[]> GetGuildRanksAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/ranks";
            return await new HttpClientHelper().GetStringAsync<GuildRank[]>(url, this.Key);
        }

        public async Task<GuildStash[]> GetGuildStashAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/stash";
            return await new HttpClientHelper().GetStringAsync<GuildStash[]>(url, this.Key);
        }

        public async Task<GuildTreasury[]> GetGuildTreasuryAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/treasury";
            return await new HttpClientHelper().GetStringAsync<GuildTreasury[]>(url, this.Key);
        }

        #endregion
    }
}
