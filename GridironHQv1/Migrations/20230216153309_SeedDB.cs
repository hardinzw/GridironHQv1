using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GridironHQv1.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Stadiums_StadiumID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_StadiumID",
                table: "Teams");

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 1, 71608, "Orchard Park", "USA", 42.773758m, -78.786837m, "Highmark Stadium", "Artificial", "NY", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 2, 64767, "Miami Gardens", "USA", 25.958056m, -80.238889m, "Hard Rock Stadium", "Grass", "FL", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 3, 82500, "East Rutherford", "USA", 40.813528m, -74.074361m, "MetLife Stadium", "Artificial", "NJ", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 4, 65878, "Foxborough", "USA", 42.090866m, -71.264244m, "Gillette Stadium", "Artificial", "MA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 5, 65515, "Cincinnati", "USA", 39.095309m, -84.516003m, "Paycor Stadium", "Artificial", "OH", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 6, 67431, "Cleveland", "USA", 41.506111m, -81.699444m, "FirstEnergy Stadium", "Grass", "OH", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 7, 71008, "Baltimore", "USA", 39.278056m, -76.622778m, "M&T Bank Stadium", "Grass", "MD", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 8, 68400, "Pittsburgh", "USA", 40.446667m, -80.015833m, "Acrisure Stadium", "Grass", "PA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 9, 67000, "Indianapolis", "USA", 39.760056m, -86.163806m, "Lucas Oil Stadium", "Artificial", "IN", "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 10, 69132, "Jacksonville", "USA", 30.323889m, -81.637500m, "TIAA Bank Field", "Grass", "FL", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 11, 72220, "Houston", "USA", 29.684722m, -95.410833m, "NRG Stadium", "Artificial", "TX", "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 12, 69143, "Nashville", "USA", 36.166389m, -86.771389m, "Nissan Stadium", "Grass", "TN", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 13, 76125, "Denver", "USA", 39.743889m, -105.020097m, "Empower Field at Mile High", "Grass", "CO", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 14, 70561, "San Diego", "USA", 32.783188m, -117.119439m, "Qualcomm Stadium", "Grass", "CA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 15, 76416, "Kansas City", "USA", 39.048889m, -94.483889m, "Arrowhead Stadium", "Grass", "MO", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 16, 53200, "Oakland", "USA", 37.751613m, -122.200509m, "RingCentral Coliseum ", "Grass", "CA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 17, 80000, "Arlington", "USA", 32.747778m, -97.092778m, "AT&T Stadium", "Artificial", "TX", "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 18, 69796, "Philadelphia", "USA", 39.900833m, -75.167469m, "Lincoln Financial Field", "Grass", "PA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 19, 82000, "Landover", "USA", 38.907778m, -76.864444m, "FedEx Field", "Grass", "MD", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 20, 61500, "Chicago", "USA", 41.862320m, -87.616699m, "Soldier Field", "Grass", "IL", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 21, 65000, "Detroit", "USA", 42.340021m, -83.045556m, "Ford Field", "Artificial", "MI", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 22, 81441, "Green Bay", "USA", 44.501389m, -88.062222m, "Lambeau Field", "Grass", "WI", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 23, 64111, "Minneapolis", "US", 44.976000m, -93.225000m, "Mall of America Field", "Artificial", "MN", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 24, 65618, "Tampa Bay", "USA", 27.975833m, -82.503333m, "Raymond James Stadium", "Grass", "FL", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 25, 74228, "Atlanta", "USA", 33.757614m, -84.400972m, "Georgia Dome", "Artificial", "GA", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 26, 74867, "Charlotte", "USA", 35.225833m, -80.852778m, "Bank of America Stadium", "Artificial", "NC", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 27, 73208, "New Orleans", "USA", 29.950833m, -90.081111m, "Caesars Superdome", "Artificial", "LA", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 28, 70207, "San Francisco", "USA", 37.404108m, -121.970274m, "Candlestick Park", "Grass", "CA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 29, 63400, "Glendale", "USA", 33.528000m, -112.263036m, "State Farm Stadium", "Grass", "AZ", "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 30, 66000, "St. Louis", "USA", 38.632975m, -90.188547m, "Edward Jones Dome", "Artificial", "MO", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 31, 68740, "Seattle", "USA", 47.595200m, -122.331625m, "Lumen Field", "Artificial", "WA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 33, 86000, "London", "UK", 51.555833m, -0.279722m, "Wembley Stadium", "Grass", null, "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 34, 86000, "Toronto", "CA", 43.641590m, -79.390028m, "Rogers Centre", "Dome", null, "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 35, 22375, "Canton", "USA", 40.819822m, -81.398177m, "Fawcett Stadium", "Artificial", "OH", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 36, 50805, "Minneapolis", "USA", 44.976000m, -93.225000m, "Huntington Bank Stadium", "Artificial", "MN", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 37, 68500, "Santa Clara", "USA", 37.403000m, -121.970274m, "Levi's Stadium", "Grass", "CA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 38, 93607, "Los Angeles", "USA", 34.014167m, -118.287778m, "Los Angeles Memorial Coliseum", "Grass", "CA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 39, 65000, "Orlando", "USA", 28.539062m, -81.402749m, "Camping World Stadium", "Artificial", "FL", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 40, 82000, "London", "UK", 51.455936m, -0.341516m, "Twickenham Stadium", "Grass", "", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 41, 87000, "Mexico City", "Mexico", 19.302861m, -99.150528m, "Estadio Azteca", "Grass", null, "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 42, 66655, "Minneapolis", "USA", 44.974288m, -93.258000m, "U.S. Bank Stadium", "Artificial", "MN", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 43, 27000, "Carson", "USA", 33.858663m, -118.256666m, "Dignity Health Sports Park", "Grass", "CA", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 45, 71000, "Atlanta", "USA", 33.755556m, -84.401000m, "Mercedes-Benz Stadium", "Artificial", "GA", "RetractableDome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 46, 23000, "Canton", "USA", 40.819906m, -81.398157m, "Tom Benson Hall of Fame Stadium", "Artificial", "OH", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 47, 62062, "London", "UK", 51.604444m, -0.066389m, "Tottenham Hotspur Stadium", "Artificial", null, "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 48, 50000, "Honolulu", "USA", 21.372647m, -157.929821m, "Aloha Stadium", "Artificial", "HI", "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 50, 33134, "Winnipeg", "CA", 49.807778m, -97.143056m, "Investors Group Field", "Artificial", null, "Outdoor" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 53, 65000, "Las Vegas", "USA", 36.090833m, -115.183611m, "Allegiant Stadium", "Grass", "NV", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 54, 70240, "Inglewood", "USA", 33.953450m, -118.339200m, "SoFi Stadium", "Artificial", "CA", "Dome" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "StadiumID", "Capacity", "City", "Country", "GeoLat", "GeoLong", "Name", "PlayingSurface", "State", "Type" },
                values: new object[] { 55, 75024, "Munich", "Germany", 48.218889m, 11.624722m, "Allianz Arena", "Grass", null, "Outdoor" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 1, 198.8m, 200.8m, 211.8m, 227.7m, 13, "Arizona", "NFC", "Vance Joseph", "3-4", "West", "Cardinals ", 355, "Arizona Cardinals", 12546, "Arizona Cardinals", 355, "Arizona Cardinals", 1, "Jonathan Gannon", "ARI", "Cardinals", null, "3WR", 1, "97233F", null, "FFFFFF", "Jeff Rodgers", 29, "000000", null, null, "Scrambled", 4, 4, null, null, "https://upload.wikimedia.org/wikipedia/en/7/72/Arizona_Cardinals_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/0/04/Arizona_Cardinals_wordmark.svg", "Arizona Cardinals", 100022 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 2, 182.9m, 194.0m, 234.7m, 257.1m, 14, "Atlanta", "NFC", "Ryan Nielsen", "3-4", "South", "Falcons ", 323, "Atlanta Falcons", 12525, "Atlanta Falcons", 323, "Atlanta Falcons", 2, "Arthur Smith", "ATL", "Falcons", "Dave Ragone", "3WR", 2, "000000", "FFFFFF", "A71930", "Marquice Williams", 45, "A5ACAF", null, null, "Scrambled", 9, 9, null, null, "https://upload.wikimedia.org/wikipedia/en/c/c5/Atlanta_Falcons_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/e/ec/Atlanta_Falcons_wordmark.svg", "Atlanta Falcons", 100001 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 3, 225.4m, 214.5m, 189.1m, 217.9m, 10, "Baltimore", "AFC", "Mike Macdonald", "3-4", "North", "Ravens ", 366, "Baltimore Ravens", 12555, "Baltimore Ravens", 366, "Baltimore Ravens", 3, "John Harbaugh", "BAL", "Ravens", "Todd Monken", "3WR", 36, "24135F", null, "000000", "Chris Horton", 7, "9A7611", null, null, "Scrambled", 12, 12, null, null, "https://upload.wikimedia.org/wikipedia/en/1/16/Baltimore_Ravens_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/a/a9/Baltimore_Ravens_wordmark.svg", "Baltimore Ravens", 100033 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 4, 151.9m, 168.7m, 156.2m, 161.3m, 7, "Buffalo", "AFC", "Leslie Frazier", "4-3", "East", "Bills ", 324, "Buffalo Bills", 12526, "Buffalo Bills", 324, "Buffalo Bills", 4, "Sean McDermott", "BUF", "Bills", "Ken Dorsey", "3WR", 37, "00338D", "00274D", "C60C30", "Matthew Smiley", 1, "FFFFFF", null, null, "Scrambled", 12, 12, null, null, "https://upload.wikimedia.org/wikipedia/en/7/77/Buffalo_Bills_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/b/bb/Buffalo_Bills_wordmark.svg", "Buffalo Bills", 100002 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 5, 196.1m, 173.2m, 238.7m, 224.8m, 13, "Carolina", "NFC", "Ejiro Evero", "4-3", "South", "Panthers ", 364, "Carolina Panthers", 12553, "Carolina Panthers", 364, "Carolina Panthers", 5, "Frank Reich", "CAR", "Panthers", "Ben McAdoo", "3WR", 5, "000000", null, "0085CA", "Chris Tabor", 26, "BFC0BF", null, null, "Scrambled", 33, 33, null, null, "https://upload.wikimedia.org/wikipedia/en/1/1c/Carolina_Panthers_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/d/dd/Carolina_Panthers_wordmark.svg", "Carolina Panthers", 100029 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 6, 236.5m, 189.5m, 226.6m, 219.2m, 14, "Chicago", "NFC", "Alan Williams", "4-3", "North", "Bears ", 326, "Chicago Bears", 12527, "Chicago Bears", 326, "Chicago Bears", 6, "Matt Eberflus", "CHI", "Bears", "Luke Getsy", "3WR", 38, "0B162A", null, "E64100", "Richard Hightower", 20, "FFFFFF", null, null, "Scrambled", 29, 29, null, null, "https://upload.wikimedia.org/wikipedia/commons/5/5c/Chicago_Bears_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/a/ae/Chicago_Bears_wordmark.svg", "Chicago Bears", 100003 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 7, 213.8m, 229.6m, 237.9m, 227.2m, 10, "Cincinnati", "AFC", "Lou Anarumo", "4-3", "North", "Bengals ", 327, "Cincinnati Bengals", 12528, "Cincinnati Bengals", 327, "Cincinnati Bengals", 7, "Zac Taylor", "CIN", "Bengals", "Brian Callahan", "3WR", 7, "000000", "", "FB4F14", "Darrin Simmons", 5, "FFFFFF", null, null, "Scrambled", 2, 2, null, null, "https://upload.wikimedia.org/wikipedia/commons/8/81/Cincinnati_Bengals_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/8/8e/Cincinnati_Bengals_wordmark.svg", "Cincinnati Bengals", 100004 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 8, 220.0m, 229.2m, 235.0m, 233.1m, 9, "Cleveland", "AFC", "Jim Schwartz", "4-3", "North", "Browns ", 329, "Cleveland Browns", 12529, "Cleveland Browns", 329, "Cleveland Browns", 8, "Kevin Stefanski", "CLE", "Browns", "Alex Van Pelt", "3WR", 8, "311D00", null, "FF3300", "Mike Priefer", 6, "FFFFFF", null, null, "Scrambled", 23, 23, null, null, "https://upload.wikimedia.org/wikipedia/en/d/d9/Cleveland_Browns_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/a/aa/Cleveland_Browns_wordmark.svg", "Cleveland Browns", 100005 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 9, 202.1m, 206.0m, 224.4m, 221.4m, 9, "Dallas", "NFC", "Dan Quinn", "4-3", "East", "Cowboys ", 331, "Dallas Cowboys", 12530, "Dallas Cowboys", 331, "Dallas Cowboys", 9, "Mike McCarthy", "DAL", "Cowboys", "Brian Schottenheimer", "3WR", 48, "002244", "FFFFFF", "B0B7BC", "John Fassel", 17, "00338D", null, null, "Scrambled", 4, 4, null, null, "https://upload.wikimedia.org/wikipedia/commons/1/15/Dallas_Cowboys.svg", "https://upload.wikimedia.org/wikipedia/commons/b/be/Cowboys_wordmark.svg", "Dallas Cowboys", 100006 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 10, 210.0m, 228.8m, 217.8m, 222.1m, 9, "Denver", "AFC", null, "3-4", "West", "Broncos ", 332, "Denver Broncos", 12531, "Denver Broncos", 332, "Denver Broncos", 10, "Sean Payton", "DEN", "Broncos", "Justin Outten", "3WR", 49, "FC4C02", null, "0A2343", "Mike Mallory (Interim)", 13, "FFFFFF", null, null, "Scrambled", 13, 13, null, null, "https://upload.wikimedia.org/wikipedia/en/4/44/Denver_Broncos_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/c/c4/Denver_Broncos_wordmark_%28c._1997%29.png", "Denver Broncos", 100007 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 11, 134.2m, 235.4m, null, 204.7m, 6, "Detroit", "NFC", "Aaron Glenn", "4-3", "North", "Lions ", 334, "Detroit Lions", 12532, "Detroit Lions", 334, "Detroit Lions", 11, "Dan Campbell", "DET", "Lions", "Ben Johnson", "3WR", 11, "0076B6", null, "B0B7BC", "Dave Fipp", 21, null, null, null, "Scrambled", 19, 19, null, null, "https://upload.wikimedia.org/wikipedia/en/7/71/Detroit_Lions_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/2/26/Detroit_Lions_wordmark.svg", "Detroit Lions", 100008 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 12, 208.7m, 207.9m, 220.1m, 197.7m, 14, "Green Bay", "NFC", "Joe Barry", "3-4", "North", "Packers ", 335, "Green Bay Packers", 12533, "Green Bay Packers", 335, "Green Bay Packers", 12, "Matt LaFleur", "GB", "Packers", "Adam Stenavich", "3WR", 12, "203731", null, "FFB612", "Rich Bisaccia", 22, "FFFFFF", null, null, "Scrambled", 8, 8, null, null, "https://upload.wikimedia.org/wikipedia/commons/5/50/Green_Bay_Packers_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/1/17/Green_Bay_Packers_wordmark.svg", "Green Bay Packers", 100009 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 13, 255.8m, 217.5m, 213.0m, 265.4m, 6, "Houston", "AFC", "Matt Burke", "4-3", "South", "Texans ", 325, "Houston Texans", 12556, "Houston Texans", 325, "Houston Texans", 13, "DeMeco Ryans", "HOU", "Texans", "Bobby Slowik", "3WR", 13, "03202F", null, "A71930", "Frank Ross", 11, "FFFFFF", null, null, "Scrambled", 44, 44, null, null, "https://upload.wikimedia.org/wikipedia/en/2/28/Houston_Texans_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/6/6c/Houston_Texans_wordmark.svg", "Houston Texans", 100034 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 14, 191.8m, 205.0m, 198.0m, 204.0m, 14, "Indianapolis", "AFC", "Gus Bradley", "4-3", "South", "Colts ", 338, "Indianapolis Colts", 12535, "Indianapolis Colts", 338, "Indianapolis Colts", 14, "Shane Steichen", "IND", "Colts", "Shane Steichen", "3WR", 14, "013369", "1D252C", "FFFFFF", "Bubba Ventrone", 9, "A5ACAF", null, null, "Scrambled", 43, 43, null, null, "https://upload.wikimedia.org/wikipedia/commons/0/00/Indianapolis_Colts_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/5/58/Indianapolis_Colts_new_wordmark.svg", "Indianapolis Colts", 100011 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 15, 254.4m, 186.4m, 189.3m, 264.0m, 11, "Jacksonville", "AFC", "Mike Caldwell", "3-4", "South", "Jaguars ", 365, "Jacksonville Jaguars", 12554, "Jacksonville Jaguars", 365, "Jacksonville Jaguars", 15, "Doug Pederson", "JAX", "Jaguars", "Press Taylor", "3WR", 52, "006778", null, "000000", "Heath Farwell", 10, "9F792C", null, null, "Scrambled", 2, 2, null, null, "https://upload.wikimedia.org/wikipedia/en/7/74/Jacksonville_Jaguars_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/7/7b/Jacksonville_Jaguars_wordmark.svg", "Jacksonville Jaguars", 100030 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 16, 213.3m, 221.2m, 232.4m, 208.0m, 8, "Kansas City", "AFC", "Steve Spagnuolo", "4-3", "West", "Chiefs ", 339, "Kansas City Chiefs", 12536, "Kansas City Chiefs", 339, "Kansas City Chiefs", 16, "Andy Reid", "KC", "Chiefs", "Eric Bieniemy", "3WR", 55, "E31837", null, "FFB612", "Dave Toub", 15, "FFFFFF", null, null, "Scrambled", 12, 12, null, null, "https://upload.wikimedia.org/wikipedia/en/e/e1/Kansas_City_Chiefs_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/7/79/Kansas_City_Chiefs_wordmark.svg", "Kansas City Chiefs", 100012 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 17, null, null, null, null, null, "Los Angeles", "AFC", null, null, "West", null, null, null, null, null, null, "Los Angeles Raiders", 17, null, "LARAID", "Raiders", null, null, 59, null, null, null, null, null, null, null, null, "Scrambled", null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 18, null, null, null, null, null, "Los Angeles", "NFC", null, null, "West", null, null, null, null, null, null, "Los Angeles Rams", 18, null, "LARAMS", "Rams", null, null, 60, null, null, null, null, null, null, null, null, "Scrambled", null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 19, 215.7m, 210.2m, 227.2m, 218.5m, 11, "Miami", "AFC", "Vic Fangio", "3-4", "East", "Dolphins ", 345, "Miami Dolphins", 12539, "Miami Dolphins", 345, "Miami Dolphins", 19, "Mike McDaniel", "MIA", "Dolphins", "Frank Smith", "3WR", 64, "008E97", "005778", "FC4C02", "Danny Crossman", 2, "FFFFFF", null, null, "Scrambled", 9, 9, null, null, "https://upload.wikimedia.org/wikipedia/en/3/37/Miami_Dolphins_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/0/09/Dolphins_textlogo13.png", "Miami Dolphins", 100015 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 20, 216.8m, 201.8m, 212.4m, 215.5m, 7, "Minnesota", "NFC", "Brian Flores", "3-4", "North", "Vikings ", 347, "Minnesota Vikings", 12540, "Minnesota Vikings", 347, "Minnesota Vikings", 20, "Kevin O'Connell", "MIN", "Vikings", "Wes Phillips", "3WR", 67, "4F2683", null, "FFC62F", "Matt Daniels", 42, "FFFFFF", null, null, "Scrambled", 16, 16, null, null, "https://upload.wikimedia.org/wikipedia/en/4/48/Minnesota_Vikings_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/9/9d/Minnesota_Vikings_wordmark.svg", "Minnesota Vikings", 100016 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 21, 212.7m, 225.2m, 233.1m, 226.3m, 10, "New England", "AFC", null, "3-4", "East", "Patriots ", 348, "New England Patriots", 12541, "New England Patriots", 348, "New England Patriots", 21, "Bill Belichick", "NE", "Patriots", "Bill O'Brien", "3WR", 21, "002244", "FFFFFF", "C60C30", "Cameron Achord", 4, "B0B7BC", null, null, "Scrambled", 9, 9, null, null, "https://upload.wikimedia.org/wikipedia/en/b/b9/New_England_Patriots_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/f/f5/New_England_Patriots_wordmark.svg", "New England Patriots", 100017 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 22, 215.7m, 205.6m, 230.7m, 215.6m, 14, "New Orleans", "NFC", "Joe Woods", "4-3", "South", "Saints ", 350, "New Orleans Saints", 12542, "New Orleans Saints", 350, "New Orleans Saints", 22, "Dennis Allen", "NO", "Saints", "Pete Carmichael", "3WR", 69, "D3BC8D", null, "000000", "Darren Rizzi", 27, "FFFFFF", null, null, "Scrambled", 28, 28, null, null, "https://upload.wikimedia.org/wikipedia/commons/5/50/New_Orleans_Saints_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/1/10/New_Orleans_Saints_first_wordmark.png", "New Orleans Saints", 100018 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 23, 237.9m, 177.9m, 218.4m, 247.5m, 9, "New York", "NFC", "Don Martindale", "3-4", "East", "Giants ", 351, "New York Giants", 12543, "New York Giants", 351, "New York Giants", 23, "Brain Daboll", "NYG", "Giants", "Mike Kafka", "3WR", 75, "0B2265", null, "A71930", "Thomas McGaughey", 3, "FFFFFF", null, null, "Scrambled", 12, 12, null, null, "https://upload.wikimedia.org/wikipedia/commons/6/60/New_York_Giants_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/4/4f/Nygiants_textlogo.png", "New York Giants", 100019 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 24, 202.4m, 239.0m, 237.9m, 179.8m, 10, "New York", "AFC", "Jeff Ulbrich", "4-3", "East", "Jets ", 352, "New York Jets", 12544, "New York Jets", 352, "New York Jets", 24, "Robert Saleh", "NYJ", "Jets", "Nathaniel Hackett", "3WR", 82, "115740", null, "FFFFFF", "Brant Boyer", 3, "000000", null, null, "Scrambled", 18, 18, null, null, "https://upload.wikimedia.org/wikipedia/en/6/6b/New_York_Jets_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/b/b6/New_York_Jets_wordmark.svg", "New York Jets", 100020 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 25, 197.4m, 221.9m, 238.3m, 261.2m, 6, "Las Vegas", "AFC", "Patrick Graham", "4-3", "West", "Raiders ", 341, "Las Vegas Raiders", 12537, "Las Vegas Raiders", 341, "Las Vegas Raiders", 25, "Josh McDaniels", "LV", "Raiders", "Mick Lombardi", "3WR", 83, "A5ACAF", null, "000000", "Tom McMahon", 53, null, null, null, "Scrambled", 2, 2, null, null, "https://upload.wikimedia.org/wikipedia/en/4/48/Las_Vegas_Raiders_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/5/51/Las_Vegas_Raiders_wordmark.svg", "Las Vegas Raiders", 100013 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 26, 214.9m, 208.2m, 213.1m, 221.0m, 7, "Philadelphia", "NFC", null, "4-3", "East", "Eagles ", 354, "Philadelphia Eagles", 12545, "Philadelphia Eagles", 354, "Philadelphia Eagles", 26, "Nick Sirianni", "PHI", "Eagles", null, "3WR", 26, "004851", "FFFFFF", "A2AAAD", "Michael Clay", 18, "000000", null, null, "Scrambled", 2, 2, null, null, "https://upload.wikimedia.org/wikipedia/en/8/8e/Philadelphia_Eagles_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/a/a5/Eagles_New_Wordmark_2022-present.png", "Philadelphia Eagles", 100021 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 27, null, null, null, null, null, "Phoenix", "NFC", null, null, "West", null, null, null, null, null, null, "Phoenix Cardinals", 27, null, "PHO", "Cardinals", null, null, 27, null, null, null, null, null, null, null, null, "Scrambled", null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 28, 190.4m, 203.1m, 198.7m, 202.1m, 9, "Pittsburgh", "AFC", "Teryl Austin", "3-4", "North", "Steelers ", 356, "Pittsburgh Steelers", 12547, "Pittsburgh Steelers", 356, "Pittsburgh Steelers", 28, "Mike Tomlin", "PIT", "Steelers", "Matt Canada", "3WR", 28, "000000", null, "FFB612", "Danny Smith", 8, null, null, null, "Scrambled", 21, 21, null, null, "https://upload.wikimedia.org/wikipedia/commons/d/de/Pittsburgh_Steelers_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/9/92/Pittsburgh_Steelers_Script.svg", "Pittsburgh Steelers", 100023 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 29, 199.6m, 202.1m, 228.2m, 200.3m, 8, "Los Angeles", "AFC", "Renaldo Hill", "3-4", "West", "Chargers ", 357, "Los Angeles Chargers", 12548, "Los Angeles Chargers", 357, "Los Angeles Chargers", 29, "Brandon Staley", "LAC", "Chargers", "Kellen Moore", "3WR", 84, "0080C6", null, "FFC20E", "Ryan Ficken", 54, "FFFFFF", null, null, "Scrambled", 6, 6, null, null, "https://upload.wikimedia.org/wikipedia/en/a/a6/Los_Angeles_Chargers_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/b/b1/Los_Angeles_Chargers_2020_wordmark.svg", "Los Angeles Chargers", 100024 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 30, 149.2m, 235.4m, 151.1m, 244.8m, 11, "Seattle", "NFC", "Clint Hurtt", "4-3", "West", "Seahawks ", 361, "Seattle Seahawks", 12550, "Seattle Seahawks", 361, "Seattle Seahawks", 30, "Pete Carroll", "SEA", "Seahawks", "Shane Waldron", "3WR", 90, "002244", null, "69BE28", "Larry Izzo", 31, "A5ACAF", null, null, "Scrambled", 4, 4, null, null, "https://upload.wikimedia.org/wikipedia/en/8/8e/Seattle_Seahawks_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/d/df/Seattle_Seahawks_wordmark.svg", "Seattle Seahawks", 100026 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 31, 192.5m, 192.0m, 199.0m, 193.7m, 9, "San Francisco", "NFC", "Steve Wilks", "4-3", "West", "49ers ", 359, "San Francisco 49ers", 12549, "San Francisco 49ers", 359, "San Francisco 49ers", 31, "Kyle Shanahan", "SF", "49ers", null, "3WR", 93, "AA0000", null, "B3995D", "Brian Schneider", 37, "FFFFFF", null, null, "Scrambled", 12, 12, null, null, "https://upload.wikimedia.org/wikipedia/commons/3/3a/San_Francisco_49ers_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/2/24/San_Francisco_49ers_wordmark.svg", "San Francisco 49ers", 100025 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 32, 172.0m, 185.4m, 184.5m, 178.5m, 7, "Los Angeles", "NFC", "Raheem Morris", "3-4", "West", "Rams ", 343, "Los Angeles Rams", 12538, "Los Angeles Rams", 343, "Los Angeles Rams", 32, "Sean McVay", "LAR", "Rams", "Mike LaFleur", "3WR", 32, "003594", null, "FFD100", null, 54, null, null, null, "Scrambled", 26, 26, null, null, "https://upload.wikimedia.org/wikipedia/en/8/8a/Los_Angeles_Rams_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/7/7e/LA_Rams_wordmark.svg", "Los Angeles Rams", 100014 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 33, 178.6m, 188.8m, 199.2m, 191.0m, 11, "Tampa Bay", "NFC", "Kacy Rodgers & Larry Foote", "3-4", "South", "Buccaneers ", 362, "Tampa Bay Buccaneers", 12551, "Tampa Bay Buccaneers", 362, "Tampa Bay Buccaneers", 33, "Todd Bowles", "TB", "Buccaneers", "Dave Canales", "3WR", 95, "A71930", "000000", "322F2B", "Keith Armstrong", 24, "DC4405", null, null, "Scrambled", 13, 13, null, null, "https://upload.wikimedia.org/wikipedia/en/a/a2/Tampa_Bay_Buccaneers_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/a/ab/Tampa_Bay_Buccaneers_wordmark.svg", "Tampa Bay Buccaneers", 100027 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 34, 202.7m, 235.4m, 227.3m, 226.3m, 6, "Tennessee", "AFC", "Shane Bowen", "3-4", "South", "Titans ", 336, "Tennessee Titans", 12534, "Tennessee Titans", 336, "Tennessee Titans", 34, "Mike Vrabel", "TEN", "Titans", "Tim Kelly", "3WR", 34, "002244", "A5ACAF", "4B92DB", "Craig Aukerman", 12, "C60C30", null, null, "Scrambled", 6, 6, null, null, "https://upload.wikimedia.org/wikipedia/en/c/c1/Tennessee_Titans_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/7/75/Tennessee_Titans_wordmark%2C_2018.svg", "Tennessee Titans", 100010 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 35, 219.4m, 207.4m, 154.0m, 220.7m, 14, "Washington", "NFC", "Jack Del Rio", "4-3", "East", "Commanders ", 363, "Washington Commanders", 12552, "Washington Redskins", 363, "Washington Commanders", 35, "Ron Rivera", "WAS", "Commanders", null, "3WR", 97, "5A1414", null, "FFB612", "Nate Kaczor", 19, "FFFFFF", null, null, "Scrambled", 13, 13, null, null, "https://upload.wikimedia.org/wikipedia/commons/0/0c/Washington_Commanders_logo.svg", "https://upload.wikimedia.org/wikipedia/commons/7/76/Washingtoncommanders_wordmark.svg", "Washington Commanders", 100028 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 36, null, null, null, null, null, "AFC", "AFC", null, null, "None", "All-Pros AFC", 478, "AFC All-Pros", 12916, null, null, "AFC All Pros", 36, null, "AFC", "All Pros", null, null, 104, null, null, null, null, null, null, null, null, "Scrambled", null, null, null, null, "https://upload.wikimedia.org/wikipedia/commons/7/7a/American_Football_Conference_logo.svg", null, "AFC All-Pros", null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "AverageDraftPosition", "AverageDraftPosition2QB", "AverageDraftPositionDynasty", "AverageDraftPositionPPR", "ByeWeek", "City", "Conference", "DefensiveCoordinator", "DefensiveScheme", "Division", "DraftKingsName", "DraftKingsPlayerID", "FanDuelName", "FanDuelPlayerID", "FantasyDraftName", "FantasyDraftPlayerID", "FullName", "GlobalTeamID", "HeadCoach", "Key", "Name", "OffensiveCoordinator", "OffensiveScheme", "PlayerID", "PrimaryColor", "QuaternaryColor", "SecondaryColor", "SpecialTeamsCoach", "StadiumID", "TertiaryColor", "UpcomingDraftKingsSalary", "UpcomingFanDuelSalary", "UpcomingOpponent", "UpcomingOpponentPositionRank", "UpcomingOpponentRank", "UpcomingSalary", "UpcomingYahooSalary", "WikipediaLogoUrl", "WikipediaWordMarkUrl", "YahooName", "YahooPlayerID" },
                values: new object[] { 37, null, null, null, null, null, "NFC", "NFC", null, null, "None", "All-Pros NFC", 479, "NFC All-Pros", 12915, null, null, "NFC All Pros", 37, null, "NFC", "All Pros", null, null, 106, null, null, null, null, null, null, null, null, "Scrambled", null, null, null, null, "https://upload.wikimedia.org/wikipedia/commons/6/6f/National_Football_Conference_logo.svg", null, "NFC All-Pros", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "StadiumID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 37);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StadiumID",
                table: "Teams",
                column: "StadiumID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Stadiums_StadiumID",
                table: "Teams",
                column: "StadiumID",
                principalTable: "Stadiums",
                principalColumn: "StadiumID");
        }
    }
}
