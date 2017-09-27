﻿using DL.GuildWars2Api.Contracts.V2;
using Xunit;

namespace DL.GuildWars2Api.Tests
{
    public class Version2AuthenticatedTests
    {
        private const string key = "";

        #region Integration Tests

        [Fact(Skip = "Integration Test; Requires API Key")]
        //[Fact]
        public void GetAccountAsync_Integration()
        {
            IAuthenticatedAccountApi api = new ApiFacade(key).V2.Account;
            var account = api.GetAccountAsync().Result;
            Assert.NotNull(account);
        }

        #endregion
    }
}
