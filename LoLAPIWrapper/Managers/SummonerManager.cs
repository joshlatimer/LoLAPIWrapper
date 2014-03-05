using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

using LoLAPIWrapper.Models;
using LoLAPIWrapper.Models.DTO;
namespace LoLAPIWrapper
{
    public class SummonerManager : BaseManager
    {
        public SummonerManager(APIConfiguration config)
            :base(config, "v1.3")
        {
        }
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <returns>The ID of a Summoner from their name and region.</returns>
        public async Task<Summoner> FromName(string name, eRegion region)
        {
            string requestPath = string.Format("summoner/by-name/{0}", "GeshZ");
            string url = BuildURL(region, requestPath);

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                string contentStr = await content.ReadAsStringAsync();
                var result = await JsonConvert.DeserializeObjectAsync<Dictionary<string, SummonerDTO>>(contentStr);
                SummonerDTO summonerDTO = result.Select(x => x.Value).FirstOrDefault();
                
                if (summonerDTO == null)
                {
                    return null;
                }
                //todo: cache summoners.
                Summoner summoner = new Summoner(summonerDTO);
                summoner.Region = region;
                return summoner;
            }
        }
    }
}
