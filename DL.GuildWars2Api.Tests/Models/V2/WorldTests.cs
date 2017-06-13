using DL.GuildWars2Api.Models.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DL.GuildWars2Api.Tests.DataTransferObjects
{
    [TestClass]
    public class WorldTests
    {
        #region ServerLocation Property Tests

        [TestMethod]
        public void ServerLocation_StartsWith1_NA()
        {
            var world = new World { Id = 1008 };
            var actual = world.ServerLocation;
            Assert.AreEqual("North America", actual);
        }

        [TestMethod]
        public void ServerLocation_StartsWith2_EU()
        {
            var world = new World { Id = 2012 };
            var actual = world.ServerLocation;
            Assert.AreEqual("Europe", actual);
        }

        [TestMethod]
        public void ServerLocation_StartsWithOther_Unknown()
        {
            var world = new World { Id = 0 };
            var actual = world.ServerLocation;
            Assert.AreEqual("Unknown", actual);
        }

        #endregion

        #region ServerLanguage Property Tests

        [TestMethod]
        public void ServerLanguage_StartsWith21_French()
        {
            var world = new World { Id = 2103 };
            var actual = world.ServerLanguage;
            Assert.AreEqual("French", actual);
        }

        [TestMethod]
        public void ServerLanguage_StartsWith22_German()
        {
            var world = new World { Id = 2203 };
            var actual = world.ServerLanguage;
            Assert.AreEqual("German", actual);
        }

        [TestMethod]
        public void ServerLanguage_StartsWith23_Spanish()
        {
            var world = new World { Id = 2301 };
            var actual = world.ServerLanguage;
            Assert.AreEqual("Spanish", actual);
        }

        [TestMethod]
        public void ServerLanguage_StartsWithOther_Unspecified()
        {
            var world = new World { Id = 0 };
            var actual = world.ServerLanguage;
            Assert.AreEqual("Unspecified", actual);
        }

        #endregion
    }
}
