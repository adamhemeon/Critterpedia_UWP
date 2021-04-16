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
            return "Name: " + this.name + "\r\nPrice: " + this.price + "\r\nSpeed: " + this.speed + "\r\nShadow: " + this.shadow +
            "\r\nCatch Phrase: " + this.catchPhrase + "\r\nMuseum Phrase: " + this.museumPhrase + "\r\nRarity: " + this.availability.rarity
            + "\r\nLocation: " + this.availability.location;
        }

    }
}
