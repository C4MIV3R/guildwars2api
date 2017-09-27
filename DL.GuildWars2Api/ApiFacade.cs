using DL.GuildWars2Api.Contracts;
using DL.GuildWars2Api.Contracts.V1;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.V1;
using DL.GuildWars2Api.V2;

namespace DL.GuildWars2Api
{
    public class ApiFacade : IApiFacade
    {
        public ApiFacade()
            : this(new Version1Facade(), new Version2Facade())
        {
        }

        public ApiFacade(string apiKey)
            : this(new Version1Facade(), new Version2Facade(), apiKey)
        {
        }

        public ApiFacade(IVersion1Api version1Api, IVersion2Api version2Api)
        {
            this.V1 = version1Api;
            this.V2 = version2Api;
        }

        public ApiFacade(IVersion1Api version1Api, IVersion2Api version2Api, string apiKey)
            : this(version1Api, version2Api)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey
        {
            get => this.V2.ApiKey;
            set => this.V2.ApiKey = value;
        }

        public IVersion1Api V1 { get; }
        public IVersion2Api V2 { get; }
    }
}
