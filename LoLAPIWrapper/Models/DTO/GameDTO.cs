using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIWrapper.Models.DTO
{
    public class GameDTO
    {
        public int gameId { get; set; }
        public bool invalid { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public string subType { get; set; }
        public int mapId { get; set; }
        public int teamId { get; set; }
        public int championId { get; set; }
        public int spell1 { get; set; }
        public int spell2 { get; set; }
        public int level { get; set; }
        public object createDate { get; set; }
        public List<FellowPlayerDTO> fellowPlayers { get; set; }
        public StatsDTO stats { get; set; }

        public bool IsRanked()
        {
            return gameType == "MATCHED_GAME";
        }
    }
}
