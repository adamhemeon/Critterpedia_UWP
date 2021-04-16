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


    }

}
