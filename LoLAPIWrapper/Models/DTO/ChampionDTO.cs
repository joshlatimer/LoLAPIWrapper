using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIWrapper.Models.DTO
{
    public class ChampionDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public int attackRank { get; set; }
        public int defenseRank { get; set; }
        public int magicRank { get; set; }
        public int difficultyRank { get; set; }
        public bool botEnabled { get; set; }
        public bool freeToPlay { get; set; }
        public bool botMmEnabled { get; set; }
        public bool rankedPlayEnabled { get; set; }
    }
}
