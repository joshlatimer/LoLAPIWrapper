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
    public class ChampionManager : BaseManager
    {
        public ChampionManager(APIConfiguration config)
            :base(config, "v1.1")
        {
        }
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <returns>The ID of a Summoner from their name and region.</returns>
        public async Task<List<ChampionDTO>> GetAllChampionsAsync(eRegion region)
        {
            string requestPath = "champion";
            string url = BuildURL(region, requestPath);

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                string contentStr = await content.ReadAsStringAsync();
                Console.WriteLine("content: " + contentStr);
                var result = await JsonConvert.DeserializeObjectAsync<Dictionary<string, List<ChampionDTO>>>(contentStr);
                List<ChampionDTO> champions = result.Select(x => x.Value).FirstOrDefault();

                return champions;
            }
        }
    }
}
