using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Models
{
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
