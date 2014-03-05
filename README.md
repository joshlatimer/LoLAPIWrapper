LoLAPIWrapper
=============
C# wrapper for the League of Legends API, more information about the LoL api at http://developer.riotgames.com/ 



Example usage:
```
LoLAPI api = new LoLAPI("api key");
Summoner summoner = await api.SummonerManager.FromName("summonerName", eRegion.euw);

List<GameDTO> games = await api.GameManager.GetSummonersRecentGames(summoner);
```
