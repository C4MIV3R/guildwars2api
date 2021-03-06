﻿using DL.GuildWars2Api.Contracts.V1;
using DL.GuildWars2Api.Contracts.V2;

namespace DL.GuildWars2Api.Contracts
{
    public interface IApiFacade
    {
        string ApiKey { get; set; }
        IVersion1Api V1 { get; }
        IVersion2Api V2 { get; }
    }
}
