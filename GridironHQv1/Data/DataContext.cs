using Microsoft.EntityFrameworkCore;
using GridironHQv1.Services;
using GridironHQv1.Entities;

namespace GridironHQv1.Data
{
    public class DataContext : DbContext
    {
        private FantasyDataService _fantasyDataService;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            _fantasyDataService = new FantasyDataService();
        }
        public DbSet<PlayerSeason> PlayerSeasons { get; set; }
        //public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        //public DbSet<News> News { get; set; }
        //public DbSet<Stadium> Stadiums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerSeason>().HasData(_fantasyDataService.GetPlayerSeasonStats());
            //modelBuilder.Entity<Team>().HasData(_fantasyDataService.GetAllTeams());
            //modelBuilder.Entity<News>().HasData(_fantasyDataService.GetNews());
            modelBuilder.Entity<Player>().HasData(_fantasyDataService.GetPlayers());
            //modelBuilder.Entity<Stadium>().HasData(_fantasyDataService.GetStadiums());
        }
    }
}
