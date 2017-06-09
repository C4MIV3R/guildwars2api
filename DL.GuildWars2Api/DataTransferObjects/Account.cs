using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Account
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "world")]
        public int WorldId { get; set; }

        [JsonProperty(PropertyName = "guilds")]
        public List<string> GuildIds { get; set; }

        [JsonProperty(PropertyName = "guild_leader")]
        public List<string> LeaderGuildIds { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        [JsonProperty(PropertyName = "commander")]
        public bool HasCommanderTag { get; set; }

        [JsonProperty(PropertyName = "fractal_level")]
        public int FractalLevel { get; set; }

        [JsonProperty(PropertyName = "daily_ap")]
        public int DailyAchievementPoints { get; set; }

        [JsonProperty(PropertyName = "monthly_ap")]
        public int MonthlyAchievementPoints { get; set; }

        [JsonProperty(PropertyName = "wvw_rank")]
        public int WvwRank { get; set; }

        public int TotalAchievementPoints => this.DailyAchievementPoints + this.MonthlyAchievementPoints;

        public DateTime CreatedDate => DateTime.Parse(this.Created).ToLocalTime();
    }
}
