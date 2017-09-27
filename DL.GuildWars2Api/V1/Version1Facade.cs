using DL.GuildWars2Api.Contracts.V1;

namespace DL.GuildWars2Api.V1
{
    internal class Version1Facade : IVersion1Api
    {
        public Version1Facade()
        {
            this.Guild = new GuildApi();
        }

        public IGuildApi Guild { get; }
    }
}
