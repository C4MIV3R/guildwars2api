using System.Collections.Generic;

namespace DL.GuildWars2Api.Models.V2
{
    public class Specializations
    {
        public List<Specialization> pve { get; set; }
        public List<Specialization> pvp { get; set; }
        public List<Specialization> wvw { get; set; }
    }
}
