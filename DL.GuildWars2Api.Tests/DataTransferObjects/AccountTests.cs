using DL.GuildWars2Api.DataTransferObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DL.GuildWars2Api.Tests.DataTransferObjects
{
    [TestClass]
    public class AccountTests
    {
        #region TotalAchievementPoints Property Tests

        [TestMethod]
        public void TotalAchievementPoints_Day0Month0_Total0()
        {
            var account = new Account { DailyAchievementPoints = 0, MonthlyAchievementPoints = 0 };
            var actual = account.TotalAchievementPoints;
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TotalAchievementPoints_Day1234Month4321_Total0()
        {
            var account = new Account { DailyAchievementPoints = 1234, MonthlyAchievementPoints = 4321 };
            var actual = account.TotalAchievementPoints;
            Assert.AreEqual(5555, actual);
        }

        #endregion
    }
}
