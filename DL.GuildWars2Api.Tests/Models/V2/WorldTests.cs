using DL.GuildWars2Api.Models.V2;
using Xunit;

namespace DL.GuildWars2Api.Tests.Models.V2
{
    public class WorldTests
    {
        [Theory]
        [InlineData(1008, "North America")]
        [InlineData(2012, "Europe")]
        [InlineData(0, "Unknown")]
        public void ServerLocation_StartsWith(int value, string expected)
        {
            var world = new World { Id = value };
            var actual = world.ServerLocation;
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2103, "French")]
        [InlineData(2203, "German")]
        [InlineData(2301, "Spanish")]
        [InlineData(0, "Unspecified")]
        public void ServerLanguage_StartsWith(int value, string expected)
        {
            var world = new World { Id = value };
            var actual = world.ServerLanguage;
            Assert.Equal(expected, actual);
        }
    }
}
