using DL.GuildWars2Api.Models.V2;
using Xunit;

namespace DL.GuildWars2Api.Tests.DataTransferObjects
{
    public class WorldTests
    {
        #region ServerLocation Property Tests

        [Fact]
        public void ServerLocation_StartsWith1_NA()
        {
            var world = new World { Id = 1008 };
            var actual = world.ServerLocation;
            Assert.Equal("North America", actual);
        }

        [Fact]
        public void ServerLocation_StartsWith2_EU()
        {
            var world = new World { Id = 2012 };
            var actual = world.ServerLocation;
            Assert.Equal("Europe", actual);
        }

        [Fact]
        public void ServerLocation_StartsWithOther_Unknown()
        {
            var world = new World { Id = 0 };
            var actual = world.ServerLocation;
            Assert.Equal("Unknown", actual);
        }

        #endregion

        #region ServerLanguage Property Tests

        [Fact]
        public void ServerLanguage_StartsWith21_French()
        {
            var world = new World { Id = 2103 };
            var actual = world.ServerLanguage;
            Assert.Equal("French", actual);
        }

        [Fact]
        public void ServerLanguage_StartsWith22_German()
        {
            var world = new World { Id = 2203 };
            var actual = world.ServerLanguage;
            Assert.Equal("German", actual);
        }

        [Fact]
        public void ServerLanguage_StartsWith23_Spanish()
        {
            var world = new World { Id = 2301 };
            var actual = world.ServerLanguage;
            Assert.Equal("Spanish", actual);
        }

        [Fact]
        public void ServerLanguage_StartsWithOther_Unspecified()
        {
            var world = new World { Id = 0 };
            var actual = world.ServerLanguage;
            Assert.Equal("Unspecified", actual);
        }

        #endregion
    }
}
