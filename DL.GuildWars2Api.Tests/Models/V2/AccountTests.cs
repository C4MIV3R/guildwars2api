using DL.GuildWars2Api.Models.V2;
using Xunit;

namespace DL.GuildWars2Api.Tests.Models.V2
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
    }
}
