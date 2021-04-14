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
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "file-name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public int price { get; set; }

        [JsonProperty(PropertyName = "price-cj")]
        public int priceCj { get; set; }

        [JsonProperty(PropertyName = "catch-phrase")]
        public string catchPhrase { get; set; }

        [JsonProperty(PropertyName = "museum-phrase")]
        public string museumPhrase { get; set; }

        [JsonProperty(PropertyName = "image_uri")]
        public string imageUri { get; set; }

        [JsonProperty(PropertyName = "icon_uri")]
        public string iconUri { get; set; }

        [JsonProperty(PropertyName = "availability")]
        public Availability availability { get; set; }

        [JsonProperty(PropertyName = "name")]
        public Name names { get; set; }

        [JsonProperty(PropertyName = "shadow")]
        public string shadow { get; set; }


    }

    public class Availability
    {
        [JsonProperty(PropertyName = "month-northern")]
        public string monthNorthern { get; set; }

        [JsonProperty(PropertyName = "month-southern")]
        public string monthSouthern { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string time { get; set; }

        [JsonProperty(PropertyName = "isAllDay")]
        public bool isAllDay { get; set; }

        [JsonProperty(PropertyName = "isAllYear")]
        public bool isAllYear{ get; set; }

        [JsonProperty(PropertyName = "location")]
        public string location { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string rarity { get; set; }

        [JsonProperty(PropertyName = "month-array-northern")]
        public int[] northernMonths{ get; set; }

        [JsonProperty(PropertyName = "month-array-southern")]
        public int[] southernMonths { get; set; }

        [JsonProperty(PropertyName = "time-array")]
        public int[] timeArray { get; set; }

    }

    public class Name
    {
        [JsonProperty(PropertyName = "name-USen")]
        public string nameUsEn { get; set; }

        [JsonProperty(PropertyName = "name-EUen")]
        public string nameEuEn { get; set; }

        [JsonProperty(PropertyName = "name-EUde")]
        public string nameEuDe { get; set; }

        [JsonProperty(PropertyName = "name-EUes")]
        public string nameEuEs { get; set; }

        [JsonProperty(PropertyName = "name-USes")]
        public string nameUsEs { get; set; }

        [JsonProperty(PropertyName = "name-EUfr")]
        public string nameEuFr { get; set; }

        [JsonProperty(PropertyName = "name-USfr")]
        public string nameUsFr { get; set; }

        [JsonProperty(PropertyName = "name-EUit")]
        public string nameEuIt { get; set; }

        [JsonProperty(PropertyName = "name-EUnl")]
        public string nameEuNl { get; set; }

        [JsonProperty(PropertyName = "name-CNzh")]
        public string nameCnZh { get; set; }

        [JsonProperty(PropertyName = "name-TWzh")]
        public string nameTwZh { get; set; }

        [JsonProperty(PropertyName = "name-JPja")]
        public string nameJpJa { get; set; }

        [JsonProperty(PropertyName = "name-KRko")]
        public string nameKrKo { get; set; }

        [JsonProperty(PropertyName = "name-EUru")]
        public string nameEuRu { get; set; }
    }
}
