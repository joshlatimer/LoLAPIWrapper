using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIWrapper.Models.DTO
{
    public class GameHistoryDTO
    {
        public int summonerId { get; set; }
        public List<GameDTO> games { get; set; }
    }
    
}
