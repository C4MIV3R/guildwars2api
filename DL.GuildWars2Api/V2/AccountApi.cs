using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class AccountApi : AuthenticatedBase, IAuthenticatedAccountApi
    {
        public AccountApi(string key)
            : base(key)
        {
        }

        public async Task<Account> GetAccountAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/account";
            return await new HttpClientHelper().GetStringAsync<Account>(url, this.Key);
        }

        public async Task<string[]> GetDungeonsAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/account/dungeons";
            return await new HttpClientHelper().GetStringAsync<string[]>(url, this.Key);
        }

        public async Task<string[]> GetRaidsAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/account/raids";
            return await new HttpClientHelper().GetStringAsync<string[]>(url, this.Key);
        }

        public async Task<TokenInfo> GetTokenInfoAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/tokeninfo";
            return await new HttpClientHelper().GetStringAsync<TokenInfo>(url, this.Key);
        }

        public async Task<WalletCurrency[]> GetWalletAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/account/wallet";
            return await new HttpClientHelper().GetStringAsync<WalletCurrency[]>(url, this.Key);
        }
    }
}
