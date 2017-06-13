using System.Collections.Generic;

namespace DL.GuildWars2Api.Models.V2
{
    public class Inventory
    {
        public int id { get; set; }
        public int count { get; set; }
        public string binding { get; set; }
        public string bound_to { get; set; }
        public int? infix_upgrade_id { get; set; }
        public List<int?> infusions { get; set; }
        public int? skin { get; set; }
        public List<int?> upgrades { get; set; }
    }
}
