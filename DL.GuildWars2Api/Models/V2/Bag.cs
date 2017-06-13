using System.Collections.Generic;

namespace DL.GuildWars2Api.Models.V2
{
    public class Bag
    {
        public int id { get; set; }
        public int size { get; set; }
        public List<Inventory> inventory { get; set; }
    }
}
