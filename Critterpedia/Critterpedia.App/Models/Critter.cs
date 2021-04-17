using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
    abstract class Critter
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "file-name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "name")]
        public Name names { get; set; }

        [JsonProperty(PropertyName = "availability")]
        public Availability availability { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string price { get; set; }

        [JsonProperty(PropertyName = "catch-phrase")]
        public string catchPhrase { get; set; }

        [JsonProperty(PropertyName = "museum-phrase")]
        public string museumPhrase { get; set; }

        [JsonProperty(PropertyName = "image_uri")]
        public string imageUri { get; set; }

        [JsonProperty(PropertyName = "icon_uri")]
        public string iconUri { get; set; }

        public string customName
        {
            get 
            {
                string nameUsEn = names.nameUsEn;

                if (string.IsNullOrEmpty(nameUsEn))
                {
                    return string.Empty;
                }

                // Retrieved from: https://docs.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=net-5.0
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                return textInfo.ToTitleCase(nameUsEn);
            }

            set
            {
                customName = value;
            }
        }
        public abstract override string ToString();
    }
}
