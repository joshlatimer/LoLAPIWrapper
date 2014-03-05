using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIWrapper
{
    public class APIConfiguration
    {
        public APIConfiguration(string key)
        {
            APIKey = key;
        }
        public string APIKey
        {
            get;
            set;
        }

        public bool IsSetup
        {
            get
            {
                return !string.IsNullOrEmpty(APIKey);
            }
        }
    }
}
