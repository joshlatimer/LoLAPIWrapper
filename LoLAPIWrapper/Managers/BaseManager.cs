using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIWrapper
{
    public abstract class BaseManager
    {
        public BaseManager(APIConfiguration config, string version)
        {
            APIConfiguration = config;
            Version = version;
        }

        APIConfiguration APIConfiguration
        {
            get;
            set;
        }
        string Version
        {
            get;
            set;
        }

        protected string BuildURL(eRegion region, string requestPath)
        {
            string baseURL = "http://prod.api.pvp.net/api/lol";

            // string url = string.Format("http://prod.api.pvp.net/api/lol/{0}/v1.2/summoner/by-name/{1}?api_key={2}", region, name, key);
            string url = string.Format("{0}/{1}/{2}/{3}?api_key={4}", baseURL, region.ToString(), Version, requestPath, APIConfiguration.APIKey);

            return url;
        }
    }
}
