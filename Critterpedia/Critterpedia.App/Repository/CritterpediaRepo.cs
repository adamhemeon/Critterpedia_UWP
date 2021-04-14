using Critterpedia.App.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Critterpedia.App.Repository
{
    class CritterpediaRepo
    {
        public async void GetFish()
        {

            string url = "http://acnhapi.com/v1a/fish";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            List<Fish> allFish = JsonConvert.DeserializeObject<List<Fish> >(response);

        }

        public async void GetSeaCreatures()
        {
            string url = "http://acnhapi.com/v1a/sea";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            List<SeaCreature> allSeaCreatures = JsonConvert.DeserializeObject<List<SeaCreature> >(response);
        }

        public async void GetBugs()
        {
            string url = "http://acnhapi.com/v1a/bugs";

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);

            List<Bug> allBugs = JsonConvert.DeserializeObject<List<Bug>>(response);
        }
    }
}
