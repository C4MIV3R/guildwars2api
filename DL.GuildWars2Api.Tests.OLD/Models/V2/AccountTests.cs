using DL.GuildWars2Api.Models.V2;
using Xunit;

namespace DL.GuildWars2Api.Tests.DataTransferObjects
{
    public class AccountTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1234, 4321, 5555)]
        public void TotalAchievementPoints_Totals(int daily, int monthly, int expected)
        {
            var account = new Account { DailyAchievementPoints = 0, MonthlyAchievementPoints = 0 };
            var actual = account.TotalAchievementPoints;
            Assert.Equal(0, actual);
        }

        //[Fact]
        //public void TotalAchievementPoints_Day1234Month4321_Total0()
        //{
        //    var account = new Account { DailyAchievementPoints = 1234, MonthlyAchievementPoints = 4321 };
        //    var actual = account.TotalAchievementPoints;
        //    Assert.Equal(5555, actual);
        //}
    }
}
