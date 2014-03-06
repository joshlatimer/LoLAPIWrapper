using System;
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
    public class SummonerUnitTest
    {
        [TestMethod]
        public async Task Summoner_FromName()
        {
            LoLAPI api = new LoLAPI("9b484226-6040-4e95-bcd1-0a2180ebe72f");
            Summoner summoner = await api.SummonerManager.FromNameAsync("GeshZ", eRegion.euw);

            Assert.AreEqual(summoner.Name, "GeshZ");
            Assert.AreEqual(summoner.Level, 30);
        }

        [TestMethod]
        public async Task Summoner_RecentGames()
        {
            LoLAPI api = new LoLAPI("9b484226-6040-4e95-bcd1-0a2180ebe72f");

            Summoner summoner = await api.SummonerManager.FromNameAsync("GeshZ", eRegion.euw);
            List<GameDTO> games = await api.GameManager.GetSummonersRecentGamesAsync(summoner);
            Assert.AreEqual(games.Count, 10); //make sure there are 10 games.
        }
    }
}
