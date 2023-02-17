using System.ComponentModel.DataAnnotations;

namespace GridironHQv1.Entities
{
    public class FantasyPlayer
    {
        public int? AuctionValue { get; set; }
        public int? AuctionValuePPR { get; set; }
        public double? AverageDraftPosition { get; set; }
        public double? AverageDraftPosition2QB { get; set; }
        public decimal? AverageDraftPositionDynasty { get; set; }
        public int? AverageDraftPositionIDP { get; set; }
        public decimal? AverageDraftPositionPPR { get; set; }
        public decimal? AverageDraftPositionRookie { get; set; }
        public int? ByeWeek { get; set; }
        [Key]
        public string? FantasyPlayerKey { get; set; }
        public decimal? LastSeasonFantasyPoints { get; set; }
        public string? Name { get; set; }
        public int PlayerID { get; set; }
        public string? Position { get; set; }
        public decimal? ProjectedFantasyPoints { get; set; }
        public string? Team { get; set; }
    }
}
