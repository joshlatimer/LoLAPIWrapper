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
    public class GameManager : BaseManager
    {
        public GameManager(APIConfiguration config)
            :base(config, "v1.3")
        {
        }
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="region"></param>
        /// <returns>The last 10 games the summoner has played.</returns>
        public async Task<List<GameDTO>> GetSummonersRecentGamesAsync(Summoner summoner)
        {
            if (summoner == null)
            {
                throw new ArgumentNullException("summoner");
            }
            if (summoner.ID == 0)
            {
                throw new ArgumentException("Summoner ID should be a value larger than 0.");
            }

            string requestPath = string.Format("game/by-summoner/{0}/recent", summoner.ID);
            string url = BuildURL(summoner.Region, requestPath);

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                string contentStr = await content.ReadAsStringAsync();
                GameHistoryDTO gameHistoryDTO = await JsonConvert.DeserializeObjectAsync<GameHistoryDTO>(contentStr);
                if (gameHistoryDTO == null)
                {
                    return null;
                }
                return gameHistoryDTO.games;
            }
        }
    }
}
