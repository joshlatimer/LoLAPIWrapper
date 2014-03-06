using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoLAPIWrapper;
using LoLAPIWrapper.Models;
using LoLAPIWrapper.Models.DTO;
namespace APITest
{
    [TestClass]
    public class ChampionUnitTest
    {
        [TestMethod]
        public async Task Champion_AllAvailableChampions()
        {
            LoLAPI api = new LoLAPI("9b484226-6040-4e95-bcd1-0a2180ebe72f");

            List<ChampionDTO> champions = await api.ChampionManager.GetAllChampionsAsync(eRegion.euw);
      
            //check for Ziggs, Zed and Ahri.
            Assert.IsTrue(champions.Where(c => c.name == "Ziggs").FirstOrDefault() != null);
            Assert.IsTrue(champions.Where(c => c.name == "Zed").FirstOrDefault() != null);
            Assert.IsTrue(champions.Where(c => c.name == "qAhri").FirstOrDefault() != null);
        }
    }
}
