﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
    class SeaCreature : Critter
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "file-name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public int price { get; set; }

        [JsonProperty(PropertyName = "catch-phrase")]
        public string catchPhrase { get; set; }

        [JsonProperty(PropertyName = "museum-phrase")]
        public string museumPhrase { get; set; }

        [JsonProperty(PropertyName = "image_uri")]
        public string imageUri { get; set; }

        [JsonProperty(PropertyName = "icon_uri")]
        public string iconUri { get; set; }

        [JsonProperty(PropertyName = "shadow")]
        public string shadow { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public string speed { get; set; }

        [JsonProperty(PropertyName = "availability")]
        public Availability availability { get; set; }

        [JsonProperty(PropertyName = "name")]
        public Name names { get; set; }
    }
}
