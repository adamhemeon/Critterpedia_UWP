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
            return "Name: " + this.name + "\r\nShadow: " + this.shadow + "\r\nPrice: " + this.price +
                "\r\nCatch Phrase: " + this.catchPhrase + "\r\nMuseum Phrase: " + this.museumPhrase + "\r\nRarity: " + this.availability.rarity
                + "\r\nLocation: " + this.availability.location;
        }

    }

}
