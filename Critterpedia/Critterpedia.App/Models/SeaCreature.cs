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

        public override string ToString()
        {
            return "Name: " + this.customName + "\r\n\nPrice: " + this.price + "\r\n\nSpeed: " + this.speed + "\r\n\nShadow: " + this.shadow +
            "\r\n\nCatch Phrase: \"" + this.catchPhrase + "\"" + "\r\n\nMuseum Phrase: \"" + this.museumPhrase + "\"";
        }

    }
}
