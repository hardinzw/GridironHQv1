using System.ComponentModel.DataAnnotations;

namespace GridironHQv1.Entities
{
    public class Player
    {
        public bool? Active { get; set; }
        public int? Age { get; set; }
        public decimal? AverageDraftPosition { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? College { get; set; }
        public string? CurrentStatus { get; set; }
        public string? CurrentTeam { get; set; }
        public bool? DeclaredInactive { get; set; }
        public int? DepthDisplayOrder { get; set; }
        public int? DepthOrder { get; set; }
        public string? DepthPosition { get; set; }
        public string? DepthPositionCategory { get; set; }
        public string? DraftKingsName { get; set; }
        public int? DraftKingsPlayerID { get; set; }
        public int? Experience { get; set; }
        public string? ExperienceString { get; set; }
        public string? FanDuelName { get; set; }
        public int? FanDuelPlayerID { get; set; }
        public int? FantasyAlarmPlayerID { get; set; }
        public string? FantasyDraftName { get; set; }
        public int? FantasyDraftPlayerID { get; set; }
        public string? FantasyPosition { get; set; }
        public int? FantasyPositionDepthOrder { get; set; }
        public string? FirstName { get; set; }
        public int? GlobalTeamID { get; set; }
        public string? Height { get; set; }
        public int? HeightFeet { get; set; }
        public int? HeightInches { get; set; }
        public string? InjuryBodyPart { get; set; }
        public string? InjuryNotes { get; set; }
        public string? InjuryPractice { get; set; }
        public string? InjuryPracticeDescription { get; set; }
        public DateTime? InjuryStartDate { get; set; }
        public string? InjuryStatus { get; set; }
        public bool IsUndraftedFreeAgent { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public string? PhotoUrl { get; set; }
        [Required]
        public int PlayerID { get; set; }
        public string? Position { get; set; }
        public string? PositionCategory { get; set; }
        public int? RotoWirePlayerID { get; set; }
        public int? RotoworldPlayerID { get; set; }
        public string? ShortName { get; set; }
        public string? SportRadarPlayerID { get; set; }
        public int? SportsDirectPlayerID { get; set; }
        public int? StatsPlayerID { get; set; }
        public string? Status { get; set; }
        public string? Team { get; set; }
        public int? TeamID { get; set; }
        public int? UpcomingDraftKingsSalary { get; set; }
        public int? UpcomingFanDuelSalary { get; set; }
        public string? UpcomingGameOpponent { get; set; }
        public int? UpcomingGameWeek { get; set; }
        public int? UpcomingOpponentPositionRank { get; set; }
        public int? UpcomingOpponentRank { get; set; }
        public int? UpcomingSalary { get; set; }
        public int? UpcomingYahooSalary { get; set; }
        public DateTime? UsaTodayHeadshotNoBackgroundUpdated { get; set; }
        public string? UsaTodayHeadshotNoBackgroundUrl { get; set; }
        public DateTime? UsaTodayHeadshotUpdated { get; set; }
        public string? UsaTodayHeadshotUrl { get; set; }
        public int? UsaTodayPlayerID { get; set; }
        public int? Weight { get; set; }
        public int? XmlTeamPlayerID { get; set; }
        public string? YahooName { get; set; }
        public int? YahooPlayerID { get; set; }

    }
}
