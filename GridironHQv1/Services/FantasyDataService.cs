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

        public List<PlayerSeason> GetPlayerSeasonStats()
        {
            NFLv3StatsClient client = new NFLv3StatsClient("");
            return client.GetPlayerSeasonStats("2022REG");
        }

        public List<Team> GetAllTeams()
        {
            NFLv3StatsClient client = new NFLv3StatsClient("");
            return client.GetAllTeams();
        }

        public List<Player> GetPlayers()
        {
            NFLv3StatsClient client = new NFLv3StatsClient("");
            return client.GetPlayers();
        }

        //public List<Stadium> GetStadiums()
        //{
        //    NFLv3StatsClient client = new NFLv3StatsClient("");
        //    return client.GetStadiums();
        //}

        //public List<News> GetNews()
        //{
        //    NFLv3StatsClient client = new NFLv3StatsClient("");
        //    return client.GetNews();
        //}
    }
}
