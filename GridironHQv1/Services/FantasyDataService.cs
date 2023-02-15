using FantasyData.Api.Client;
using FantasyData.Api.Client.Model.NFLv3;

namespace GridironHQv1.Services
{
    public class FantasyDataService
    {
        private readonly IConfiguration _configuration;
        private NFLv3StatsClient _client;

        public FantasyDataService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public FantasyDataService()
        {
            _client = new NFLv3StatsClient(_configuration["APIKeys:FantasyDataKey"]);
        }

        public List<Player> GetPlayers()
        {
            return _client.GetPlayers();
        }

        public List<Team> GetAllTeams()
        {
            return _client.GetAllTeams();
        }

        public List<Stadium> GetStadiums()
        {

            return _client.GetStadiums();
        }
    }
}
