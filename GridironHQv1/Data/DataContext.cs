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
        }

        //public DataContext()
        //{
        //    _fantasyDataService = new FantasyDataService();
        //}

        public DbSet<Team> Teams { get; set; }
        //public DbSet<Player> Players { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Team>().HasData(_fantasyDataService.GetAllTeams());
        //}
    }
}
