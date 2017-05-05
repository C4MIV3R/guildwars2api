using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Character
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "race")]
        public string Race { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "profession")]
        public string Profession { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "guild")]
        public string GuildId { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

        public string AgeDisplay
        {
            get
            {
                int secondsRemaining = this.Age;

                int secondsInHour = 3600;
                int hours = secondsRemaining / secondsInHour;
                secondsRemaining = secondsRemaining - (hours * secondsInHour);

                int secondsInMinute = 60;
                int minutes = secondsRemaining / secondsInMinute;
                secondsRemaining = secondsRemaining - (minutes * secondsInMinute);
                int seconds = secondsRemaining;

                return $"{hours} hours, {minutes} minutes";
            }
        }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        public DateTime Birthday => DateTime.Parse(this.Created).ToLocalTime();

        [JsonProperty(PropertyName = "deaths")]
        public int Deaths { get; set; }

        [JsonProperty(PropertyName = "crafting")]
        public List<Crafting> Crafting { get; set; }

        [JsonProperty(PropertyName = "specializations")]
        public Specializations Specializations { get; set; }

        [JsonProperty(PropertyName = "equipment")]
        public List<Equipment> Equipment { get; set; }

        [JsonProperty(PropertyName = "recipes")]
        public List<int> Recipes { get; set; }

        [JsonProperty(PropertyName = "bags")]
        public List<Bag> Bags { get; set; }
    }
}
