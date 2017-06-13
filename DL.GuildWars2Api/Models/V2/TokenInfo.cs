﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DL.GuildWars2Api.Models.V2
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TokenInfo
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "permissions")]
        public List<string> Permissions { get; set; }

        public bool HasGuildsPermission => this.Permissions.Any() && this.Permissions.Contains("guilds");
    }
}
