using DL.GuildWars2Api.Contracts;
using Xunit;

namespace DL.GuildWars2Api.Tests
{
    public class Version2AuthenticatedTests
    {
        private const string key = "";

        #region Integration Tests

        [Fact(Skip = "Integration Test")]
        //[Fact]
        public void GetAccountAsync_Integration()
        {
            IVersion2AuthenticatedApi api = new ApiFacade(key).V2.Authenticated;
            var account = api.GetAccountAsync().Result;
            Assert.NotNull(account);
        }

        #endregion
    }
}
