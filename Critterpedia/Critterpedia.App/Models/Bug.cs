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

    }
}
