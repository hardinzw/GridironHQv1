using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GridironHQv1.Migrations
{
    /// <inheritdoc />
    public partial class InitialPlayerSeasons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerSeasons",
                columns: table => new
                {
                    PlayerSeasonID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FantasyPoints = table.Column<decimal>(type: "TEXT", nullable: true),
                    FantasyPointsDraftKings = table.Column<decimal>(type: "TEXT", nullable: true),
                    FantasyPointsFanDuel = table.Column<decimal>(type: "TEXT", nullable: true),
                    FantasyPointsFantasyDraft = table.Column<decimal>(type: "TEXT", nullable: true),
                    FantasyPointsPPR = table.Column<decimal>(type: "TEXT", nullable: false),
                    FantasyPointsYahoo = table.Column<decimal>(type: "TEXT", nullable: true),
                    FantasyPosition = table.Column<string>(type: "TEXT", nullable: true),
                    GlobalTeamID = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Number = table.Column<int>(type: "INTEGER", nullable: true),
                    OffensiveSnapsPlayed = table.Column<int>(type: "INTEGER", nullable: true),
                    OffensiveTeamSnaps = table.Column<int>(type: "INTEGER", nullable: true),
                    OffensiveTouchdowns = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingAttempts = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingCompletionPercentage = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingCompletions = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingInterceptions = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingLong = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingRating = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingTouchdowns = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingYards = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingYardsPerAttempt = table.Column<decimal>(type: "TEXT", nullable: true),
                    PassingYardsPerCompletion = table.Column<decimal>(type: "TEXT", nullable: true),
                    Played = table.Column<int>(type: "INTEGER", nullable: true),
                    PlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    PositionCategory = table.Column<string>(type: "TEXT", nullable: true),
                    ReceivingLong = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReceivingTargets = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReceivingTouchdowns = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReceivingYards = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReceivingYardsPerReception = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReceivingYardsPerTarget = table.Column<decimal>(type: "TEXT", nullable: true),
                    ReceptionPercentage = table.Column<decimal>(type: "TEXT", nullable: true),
                    Receptions = table.Column<decimal>(type: "TEXT", nullable: true),
                    RushingAttempts = table.Column<decimal>(type: "TEXT", nullable: true),
                    RushingLong = table.Column<decimal>(type: "TEXT", nullable: true),
                    RushingTouchdowns = table.Column<decimal>(type: "TEXT", nullable: true),
                    RushingYards = table.Column<decimal>(type: "TEXT", nullable: true),
                    RushingYardsPerAttempt = table.Column<decimal>(type: "TEXT", nullable: true),
                    Season = table.Column<int>(type: "INTEGER", nullable: true),
                    SeasonType = table.Column<int>(type: "INTEGER", nullable: true),
                    ShortName = table.Column<string>(type: "TEXT", nullable: true),
                    Started = table.Column<int>(type: "INTEGER", nullable: true),
                    Team = table.Column<string>(type: "TEXT", nullable: true),
                    TeamID = table.Column<int>(type: "INTEGER", nullable: true),
                    Touchdowns = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSeasons", x => x.PlayerSeasonID);
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerID",
                keyValue: 22417,
                columns: new[] { "DepthDisplayOrder", "DepthOrder" },
                values: new object[] { 3, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerSeasons");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerID",
                keyValue: 22417,
                columns: new[] { "DepthDisplayOrder", "DepthOrder" },
                values: new object[] { null, null });
        }
    }
}
