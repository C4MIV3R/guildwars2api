using DL.GuildWars2Api.Contracts.V2;

namespace DL.GuildWars2Api.Contracts
{
    public interface IVersion2Api : 
        ICurrencyApi,
        IDungeonApi,
        IGuildApi,
        IItemApi,
        IRaidApi,
        ISkinApi,
        IWorldApi
    {
        IVersion2AuthenticatedApi Authenticated { get; set; }
    }
}
