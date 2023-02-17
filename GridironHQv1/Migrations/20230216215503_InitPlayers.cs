using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GridironHQv1.Migrations
{
    /// <inheritdoc />
    public partial class InitPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Active = table.Column<bool>(type: "INTEGER", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: true),
                    AverageDraftPosition = table.Column<decimal>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    College = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentStatus = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentTeam = table.Column<string>(type: "TEXT", nullable: true),
                    DeclaredInactive = table.Column<bool>(type: "INTEGER", nullable: true),
                    DepthDisplayOrder = table.Column<int>(type: "INTEGER", nullable: true),
                    DepthOrder = table.Column<int>(type: "INTEGER", nullable: true),
                    DepthPosition = table.Column<string>(type: "TEXT", nullable: true),
                    DepthPositionCategory = table.Column<string>(type: "TEXT", nullable: true),
                    DraftKingsName = table.Column<string>(type: "TEXT", nullable: true),
                    DraftKingsPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    Experience = table.Column<int>(type: "INTEGER", nullable: true),
                    ExperienceString = table.Column<string>(type: "TEXT", nullable: true),
                    FanDuelName = table.Column<string>(type: "TEXT", nullable: true),
                    FanDuelPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    FantasyAlarmPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    FantasyDraftName = table.Column<string>(type: "TEXT", nullable: true),
                    FantasyDraftPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    FantasyPosition = table.Column<string>(type: "TEXT", nullable: true),
                    FantasyPositionDepthOrder = table.Column<int>(type: "INTEGER", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    GlobalTeamID = table.Column<int>(type: "INTEGER", nullable: true),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    HeightFeet = table.Column<int>(type: "INTEGER", nullable: true),
                    HeightInches = table.Column<int>(type: "INTEGER", nullable: true),
                    InjuryBodyPart = table.Column<string>(type: "TEXT", nullable: true),
                    InjuryNotes = table.Column<string>(type: "TEXT", nullable: true),
                    InjuryPractice = table.Column<string>(type: "TEXT", nullable: true),
                    InjuryPracticeDescription = table.Column<string>(type: "TEXT", nullable: true),
                    InjuryStartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InjuryStatus = table.Column<string>(type: "TEXT", nullable: true),
                    IsUndraftedFreeAgent = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Number = table.Column<int>(type: "INTEGER", nullable: true),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    PositionCategory = table.Column<string>(type: "TEXT", nullable: true),
                    RotoWirePlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    RotoworldPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    ShortName = table.Column<string>(type: "TEXT", nullable: true),
                    SportRadarPlayerID = table.Column<string>(type: "TEXT", nullable: true),
                    SportsDirectPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    StatsPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Team = table.Column<string>(type: "TEXT", nullable: true),
                    TeamID = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingDraftKingsSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingFanDuelSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingGameOpponent = table.Column<string>(type: "TEXT", nullable: true),
                    UpcomingGameWeek = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingOpponentPositionRank = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingOpponentRank = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UpcomingYahooSalary = table.Column<int>(type: "INTEGER", nullable: true),
                    UsaTodayHeadshotNoBackgroundUpdated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UsaTodayHeadshotNoBackgroundUrl = table.Column<string>(type: "TEXT", nullable: true),
                    UsaTodayHeadshotUpdated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UsaTodayHeadshotUrl = table.Column<string>(type: "TEXT", nullable: true),
                    UsaTodayPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true),
                    XmlTeamPlayerID = table.Column<int>(type: "INTEGER", nullable: true),
                    YahooName = table.Column<string>(type: "TEXT", nullable: true),
                    YahooPlayerID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
