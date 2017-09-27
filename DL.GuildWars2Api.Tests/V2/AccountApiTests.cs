using DL.GuildWars2Api.Contracts.V2;
using Xunit;

namespace DL.GuildWars2Api.Tests.V2
{
    public class AccountApiTests
    {
        private const string key = "";

        [Fact(Skip = "Integration Test; Requires API Key")]
        public void GetAccountAsync_Integration()
        {
            IAuthenticatedAccountApi api = new ApiFacade(key).V2.Account;
            var account = api.GetAccountAsync().Result;
            Assert.NotNull(account);
        }
    }
}
