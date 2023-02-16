using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GridironHQv1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    StadiumID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    GeoLat = table.Column<decimal>(type: "TEXT", nullable: true),
                    GeoLong = table.Column<decimal>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PlayingSurface = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.StadiumID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AverageDraftPosition = table.Column<decimal>(type: "TEXT", nullable: true),
                    AverageDraftPosition2QB = table.Column<decimal>(type: "TEXT", nullable: true),
                    AverageDraftPositionDynasty = table.Column<decimal>(type: "TEXT", nullable: true),
                    AverageDraftPositionPPR = table.Column<decimal>(type: "TEXT", nullable: true),
                    ByeWeek = table.Column<int>(type: "INTEGER", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Conference = table.Column<string>(type: "TEXT", nullable: true),
                    DefensiveCoordinator = table.Column<string>(type: "TEXT", nullable: true),
                    DefensiveScheme = table.Column<string>(type: "TEXT", nullable: true),
                    Division = table.Column<string>(type: "TEXT", nullable: true),
                    DraftKingsName = table.Column<string>(type: "TEXT", nullable: true),
                    DraftKingsPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    FanDuelName = table.Column<string>(type: "TEXT", nullable: true),
                    FanDuelPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    FantasyDraftName = table.Column<string>(type: "TEXT", nullable: true),
                    FantasyDraftPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    GlobalTeamID = table.Column<int>(type: "INTEGER", nullable: true),
                    HeadCoach = table.Column<string>(type: "TEXT", nullable: true),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OffensiveCoordinator = table.Column<string>(type: "TEXT", nullable: true),
                    OffensiveScheme = table.Column<string>(type: "TEXT", nullable: true),
                    PlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    PrimaryColor = table.Column<string>(type: "TEXT", nullable: true),
                    QuaternaryColor = table.Column<string>(type: "TEXT", nullable: true),
                    SecondaryColor = table.Column<string>(type: "TEXT", nullable: true),
                    SpecialTeamsCoach = table.Column<string>(type: "TEXT", nullable: true),
                    StadiumID = table.Column<int>(type: "INTEGER", nullable: true),
                    TertiaryColor = table.Column<string>(type: "TEXT", nullable: true),
                    UpcomingDraftKingsSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingFanDuelSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingOpponent = table.Column<string>(type: "TEXT", nullable: true),
                    UpcomingOpponentPositionRank = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingOpponentRank = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingYahooSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    WikipediaLogoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    WikipediaWordMarkUrl = table.Column<string>(type: "TEXT", nullable: true),
                    YahooName = table.Column<string>(type: "TEXT", nullable: true),
                    YahooPlayerID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Stadiums_StadiumID",
                        column: x => x.StadiumID,
                        principalTable: "Stadiums",
                        principalColumn: "StadiumID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StadiumID",
                table: "Teams",
                column: "StadiumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Stadiums");
        }
    }
}
