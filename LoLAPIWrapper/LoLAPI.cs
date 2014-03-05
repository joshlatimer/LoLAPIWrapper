using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIWrapper
{
    public class LoLAPI
    {
        APIConfiguration Configuration = null;
        public LoLAPI(string apiKey)
        {
            Configuration = new APIConfiguration(apiKey);
            SummonerManager = new SummonerManager(Configuration);
            GameManager = new GameManager(Configuration);
        }


        public SummonerManager SummonerManager
        {
            get;
            set;
        }
        public GameManager GameManager
        {
            get;
            set;
        }
    }
    public enum eRegion
    {
        euw,
        na,
    }
}
