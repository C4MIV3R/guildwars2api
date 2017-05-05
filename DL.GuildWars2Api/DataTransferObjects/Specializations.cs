using System.Collections.Generic;

namespace DL.GuildWars2Api.DataTransferObjects
{
    public class Specializations
    {
        public List<Specialization> pve { get; set; }
        public List<Specialization> pvp { get; set; }
        public List<Specialization> wvw { get; set; }
    }
}
