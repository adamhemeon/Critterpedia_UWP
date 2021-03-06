using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
    class Fish : Critter
    {

        [JsonProperty(PropertyName = "price-cj")]
        public int priceCj { get; set; }


        [JsonProperty(PropertyName = "shadow")]
        public string shadow { get; set; }

        public override string ToString()
        {
            return "Name: " + this.customName + "\r\n\nShadow: " + this.shadow + "\r\n\nPrice: " + this.price + "\r\n\nCJ Price: " + this.priceCj +
                "\r\n\nRarity: " + this.availability.rarity + "\r\n\nLocation: " + this.availability.location +
                "\r\n\nCatch Phrase: \"" + this.catchPhrase + "\"" + "\r\n\nMuseum Phrase: \"" + this.museumPhrase + "\"";
        }

    }

}
