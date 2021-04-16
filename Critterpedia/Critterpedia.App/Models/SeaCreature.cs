using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
    class SeaCreature : Critter
    {

        [JsonProperty(PropertyName = "shadow")]
        public string shadow { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public string speed { get; set; }

    }
}
