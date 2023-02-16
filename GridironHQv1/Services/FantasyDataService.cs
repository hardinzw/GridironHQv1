using FantasyData.Api.Client;
using FantasyData.Api.Client.Model.NFLv3;

namespace GridironHQv1.Services
{
    public class FantasyDataService
    {
        //private readonly IConfiguration _configuration;
        //private NFLv3StatsClient _client;

        //public FantasyDataService(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //public FantasyDataService()
        //{
        //    _client = new NFLv3StatsClient(_configuration["APIKeys:FantasyDataKey"]);
        //}

        //public List<Player> GetPlayers()
        //{
        //    return _client.GetPlayers();
        //}

        public List<Team> GetAllTeams()
        {
            NFLv3StatsClient client = new NFLv3StatsClient("f5c1a5ae83ef431cbc47e1845a0cc4c4");
            return client.GetAllTeams();
        }

        public List<Stadium> GetStadiums()
        {
            NFLv3StatsClient client = new NFLv3StatsClient("f5c1a5ae83ef431cbc47e1845a0cc4c4");
            return client.GetStadiums();
        }
    }
}
