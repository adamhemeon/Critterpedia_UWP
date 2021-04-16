using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
    public class Availability
    {
        [JsonProperty(PropertyName = "month-northern")]
        public string monthNorthern { get; set; }

        [JsonProperty(PropertyName = "month-southern")]
        public string monthSouthern { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string time { get; set; }

        [JsonProperty(PropertyName = "isAllDay")]
        public bool isAllDay { get; set; }

        [JsonProperty(PropertyName = "isAllYear")]
        public bool isAllYear { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string location { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string rarity { get; set; }

        [JsonProperty(PropertyName = "month-array-northern")]
        public int[] northernMonths { get; set; }

        [JsonProperty(PropertyName = "month-array-southern")]
        public int[] southernMonths { get; set; }

        [JsonProperty(PropertyName = "time-array")]
        public int[] timeArray { get; set; }
    }
}
