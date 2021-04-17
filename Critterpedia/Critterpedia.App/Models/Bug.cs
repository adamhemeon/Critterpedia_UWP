using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
    class Bug : Critter
    {

        [JsonProperty(PropertyName = "price-flick")]
        public string priceFlick { get; set; }
        public override string ToString()
        {
            return "Name: " + this.customName + "\r\n\nPrice: " + this.price + "\r\n\nFlick Price: " + this.priceFlick +
            "\r\n\nRarity: " + this.availability.rarity + "\r\n\nLocation: " + this.availability.location + 
            "\r\n\nCatch Phrase: \"" + this.catchPhrase + "\"" + "\r\n\nMuseum Phrase: \"" + this.museumPhrase + "\"";
        }
    }
}
