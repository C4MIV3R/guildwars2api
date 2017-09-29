using System.IO;
using System.Linq;

namespace DL.GuildWars2Api.Tests
{
    internal static class TestHelper
    {
        internal static string GetApiKey()
        {
            const string path = @"C:\src\secrets\gw2-key.txt";
            if (!File.Exists(path))
            {
                return string.Empty;
            }

            var lines = File.ReadLines(path);
            return lines.First().Trim();
        }
    }
}
