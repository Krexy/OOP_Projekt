using Newtonsoft.Json;
using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Podatkovni_sloj
{
    public static class Podaci
    {
        private static System.Net.WebRequest WebRequest { get; set; }

        public async static Task<List<Teams>> GetTeams()
        {
            WebRequest = WebRequest.Create("https://world-cup-json-2018.herokuapp.com/teams/results") as HttpWebRequest;
            using (var stream = WebRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    return 
                        await Task.Run(()=>JsonConvert
                        .DeserializeObject<List<Teams>>(contributorsAsJson))
                        .ConfigureAwait(false);
                }
            }
        }
        //public async static Task<Teams> GetTeam(string f_code)
        //{
        //    WebRequest = WebRequest.Create($"https://world-cup-json-2018.herokuapp.com/teams/results?fifa_code{f_code}") as HttpWebRequest;
        //    using (var stream = WebRequest.GetResponse().GetResponseStream())
        //    {
        //        using (var sr = new StreamReader(stream))
        //        {
        //            var contributorsAsJson = sr.ReadToEnd();
        //            return
        //                await Task.Run(() => JsonConvert
        //                .DeserializeObject<Teams>(contributorsAsJson))
        //                .ConfigureAwait(false);
        //        }
        //    }
        //}
        public static async Task<List<Matches>> GetMatches(String fifa_code)
        {
            WebRequest = WebRequest.Create($"https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code={fifa_code}") as HttpWebRequest;
            using (var stream = WebRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    return 
                        await Task.Run(()=>JsonConvert
                        .DeserializeObject<List<Matches>>(contributorsAsJson))
                        .ConfigureAwait(false);
                }
            }
        }
    }
}
