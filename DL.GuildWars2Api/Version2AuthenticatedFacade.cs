using System;
using System.Threading.Tasks;
using DL.GuildWars2Api.DataTransferObjects;

namespace DL.GuildWars2Api
{
    public class Version2AuthenticatedFacade
    {
        public string ApiKey { get; set; }
        public bool HasKey => !string.IsNullOrWhiteSpace(this.ApiKey);

        #region General / Misc

        public async Task<Account> GetAccountAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/account";
            return await new HttpClientHelper().GetStringAsync<Account>(url, this.ApiKey);
        }

        public async Task<TokenInfo> GetTokenInfoAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/tokeninfo";
            return await new HttpClientHelper().GetStringAsync<TokenInfo>(url, this.ApiKey);
        }

        public async Task<WalletCurrency[]> GetWalletAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/account/wallet";
            return await new HttpClientHelper().GetStringAsync<WalletCurrency[]>(url, this.ApiKey);
        }

        #endregion

        #region Characters

        public async Task<string[]> GetCharactersAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/characters";
            return await new HttpClientHelper().GetStringAsync<string[]>(url, this.ApiKey);
        }

        public async Task<Character> GetCharacterAsync(string characterName)
        {
            this.EnsureApiKey();
            var name = characterName.Replace(" ", "%20");
            var url = $"v2/characters/{name}";
            return await new HttpClientHelper().GetStringAsync<Character>(url, this.ApiKey);
        }

        #endregion

        #region Guilds

        public async Task<GuildLog[]> GetGuildLogAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/log";
            return await new HttpClientHelper().GetStringAsync<GuildLog[]>(url, this.ApiKey);
        }

        public async Task<GuildMember[]> GetGuildMemberAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/members";
            return await new HttpClientHelper().GetStringAsync<GuildMember[]>(url, this.ApiKey);
        }

        public async Task<GuildRank[]> GetGuildRanksAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/ranks";
            return await new HttpClientHelper().GetStringAsync<GuildRank[]>(url, this.ApiKey);
        }

        public async Task<GuildStash[]> GetGuildStashAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/stash";
            return await new HttpClientHelper().GetStringAsync<GuildStash[]>(url, this.ApiKey);
        }

        public async Task<GuildTreasury[]> GetGuildTreasuryAsync(string guildId)
        {
            this.EnsureApiKey();
            var url = $"v2/guild/{guildId}/treasury";
            return await new HttpClientHelper().GetStringAsync<GuildTreasury[]>(url, this.ApiKey);
        }

        #endregion  

        private void EnsureApiKey()
        {
            if (!this.HasKey)
            {
                throw new InvalidOperationException("An API key must be set before callig this method.");
            }
        }
    }
}
