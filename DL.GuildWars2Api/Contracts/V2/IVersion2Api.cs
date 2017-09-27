namespace DL.GuildWars2Api.Contracts.V2
{
    public interface IVersion2Api
    {
        string ApiKey { get; set; }
        IAuthenticatedAccountApi Account { get; }
        IAuthenticatedCharacterApi Character { get; }
        ICurrencyApi Currency { get; }
        IDungeonApi Dungeon { get; }
        IAuthenticatedGuildApi Guild { get; }
        IItemApi Item { get; }
        IRaidApi Raid { get; }
        ISkinApi Skin { get; }
        IWorldApi World { get; }
    }
}
