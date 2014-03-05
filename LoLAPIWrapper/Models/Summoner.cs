using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLAPIWrapper.Models.DTO;

namespace LoLAPIWrapper.Models
{
    public class Summoner
    {
        public Summoner(SummonerDTO summoner)
        {
            ID = summoner.id;
            Name = summoner.name;
            Level = summoner.summonerLevel;
        }

        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Level
        {
            get;
            set;
        }
        public eRegion Region
        {
            get;
            set;
        }
    }
}
