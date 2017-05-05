using System.Collections.Generic;

namespace DL.GuildWars2Api.DataTransferObjects
{
    public class Bag
    {
        public int id { get; set; }
        public int size { get; set; }
        public List<Inventory> inventory { get; set; }
    }
}
