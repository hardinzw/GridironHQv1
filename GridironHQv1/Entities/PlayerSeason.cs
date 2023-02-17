using System.ComponentModel.DataAnnotations;

namespace GridironHQv1.Entities
{
    public class PlayerSeason
    {
        public decimal? FantasyPoints { get; set; }
        public decimal? FantasyPointsDraftKings { get; set; }
        public decimal? FantasyPointsFanDuel { get; set; }
        public decimal? FantasyPointsFantasyDraft { get; set; }
        public decimal FantasyPointsPPR { get; set; }
        public decimal? FantasyPointsYahoo { get; set; }
        public string? FantasyPosition { get; set; }
        public int? GlobalTeamID { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public int? OffensiveSnapsPlayed { get; set; }
        public int? OffensiveTeamSnaps { get; set; }
        public decimal? OffensiveTouchdowns { get; set; }
        public decimal? PassingAttempts { get; set; }
        public decimal? PassingCompletionPercentage { get; set; }
        public decimal? PassingCompletions { get; set; }
        public decimal? PassingInterceptions { get; set; }
        public decimal? PassingLong { get; set; }
        public decimal? PassingRating { get; set; }
        public decimal? PassingTouchdowns { get; set; }
        public decimal? PassingYards { get; set; }
        public decimal? PassingYardsPerAttempt { get; set; }
        public decimal? PassingYardsPerCompletion { get; set; }
        public int? Played { get; set; }
        public int? PlayerID { get; set; }
        public int PlayerSeasonID { get; set; }
        public string? Position { get; set; }
        public string? PositionCategory { get; set; }
        public decimal? ReceivingLong { get; set; }
        public decimal? ReceivingTargets { get; set; }
        public decimal? ReceivingTouchdowns { get; set; }
        public decimal? ReceivingYards { get; set; }
        public decimal? ReceivingYardsPerReception { get; set; }
        public decimal? ReceivingYardsPerTarget { get; set; }
        public decimal? ReceptionPercentage { get; set; }
        public decimal? Receptions { get; set; }
        public decimal? RushingAttempts { get; set; }
        public decimal? RushingLong { get; set; }
        public decimal? RushingTouchdowns { get; set; }
        public decimal? RushingYards { get; set; }
        public decimal? RushingYardsPerAttempt { get; set; }
        public int? Season { get; set; }
        public int? SeasonType { get; set; }
        public string? ShortName { get; set; }
        public int? Started { get; set; }
        public string? Team { get; set; }
        public int? TeamID { get; set; }
        public decimal? Touchdowns { get; set; }
    }
}
