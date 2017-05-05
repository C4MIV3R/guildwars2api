﻿using System.Collections.Generic;

namespace DL.GuildWars2Api.DataTransferObjects
{
    public class Equipment
    {
        public int id { get; set; }
        public string slot { get; set; }
        public List<int> upgrades { get; set; }
        public List<int?> infusions { get; set; }
        public int? skin { get; set; }
    }
}
