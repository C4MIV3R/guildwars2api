namespace DL.GuildWars2Api
{
    public class ApiFacade
    {
        public ApiFacade()
        {
            this.V1 = new Version1Facade();
            this.V2 = new Version2Facade();
        }

        public ApiFacade(string apiKey)
            : this()
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey
        {
            get { return this.V2.Authenticated.ApiKey; }
            set { this.V2.Authenticated.ApiKey = value; }
        }

        public Version1Facade V1 { get; }
        public Version2Facade V2 { get; }
    }
}
