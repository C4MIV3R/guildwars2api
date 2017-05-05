using System;
using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildLog
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string LogType { get; set; }

        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        [JsonProperty(PropertyName = "item_id")]
        public int? ItemId { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        [JsonProperty(PropertyName = "coins")]
        public int? Coins { get; set; }

        [JsonProperty(PropertyName = "motd")]
        public string Motd { get; set; }

        [JsonProperty(PropertyName = "upgrade_id")]
        public int? UpgradeId { get; set; }

        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        [JsonProperty(PropertyName = "kicked_by")]
        public string KickedBy { get; set; }

        [JsonProperty(PropertyName = "invited_by")]
        public string InvitedBy { get; set; }

        [JsonProperty(PropertyName = "changed_by")]
        public string ChangedBy { get; set; }

        [JsonProperty(PropertyName = "old_rank")]
        public string OldRank { get; set; }

        [JsonProperty(PropertyName = "new_rank")]
        public string NewRank { get; set; }

        [JsonProperty(PropertyName = "activity")]
        public string Activity { get; set; }

        [JsonProperty(PropertyName = "total_participants")]
        public int? TotalParticipants { get; set; }

        [JsonProperty(PropertyName = "participants")]
        public object[] Participants { get; set; }

        [JsonProperty(PropertyName = "declined_by")]
        public string DeclinedBy { get; set; }

        public DateTime Datestamp => DateTime.Parse(this.Time);
    }
}
