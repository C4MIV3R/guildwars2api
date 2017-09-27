using DL.GuildWars2Api.V2;
using System;
using Xunit;

namespace DL.GuildWars2Api.Tests.V2
{
    public class AuthenticatedBaseTests
    {
        #region EnsureApiKey() Tests

        [Fact]
        public void EnsureApiKey_NoKey_ThrowsInvalidOperationException()
        {
            var sut = new AuthenticatedBaseTester();
            Assert.Throws<InvalidOperationException>(() => sut.EnsureApiKeyTest());
        }

        #endregion

        #region IsKeyValid() Tests

        [Theory]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("x", true)]
        public void IsKeyValid_Tests(string key, bool expected)
        {
            var sut = new AuthenticatedBaseTester(key);
            var actual = sut.IsKeyValidTest();
            Assert.Equal(expected, actual);
        }

        #endregion

        private class AuthenticatedBaseTester : AuthenticatedBase
        {
            public AuthenticatedBaseTester() : base(string.Empty)
            {
            }

            public AuthenticatedBaseTester(string key) : base(key)
            {
            }

            public void EnsureApiKeyTest()
            {
                this.EnsureApiKey();
            }

            public void EnsureApiKeyTest(string key)
            {
                this.EnsureApiKey(key);
            }

            public bool IsKeyValidTest()
            {
                return this.IsKeyValid();
            }

            public bool IsKeyValidTest(string key)
            {
                return this.IsKeyValid(key);
            }
        }
    }
}
