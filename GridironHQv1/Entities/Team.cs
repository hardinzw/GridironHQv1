using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GridironHQv1.Entities
{
    public class Team
    {
        public int? ByeWeek { get; set; }
        public string? City { get; set; }
        public string? Conference { get; set; }
        public string? DefensiveCoordinator { get; set; }
        public string? DefensiveScheme { get; set; }
        public string? Division { get; set; }
        public string? FullName { get; set; }
        public int? GlobalTeamID { get; set; }
        public string? HeadCoach { get; set; }
        public string? Key { get; set; }
        public string? Name { get; set; }
        public string? OffensiveCoordinator { get; set; }
        public string? OffensiveScheme { get; set; }
        public int? PlayerID { get; set; }
        public string? PrimaryColor { get; set; }
        public string? QuaternaryColor { get; set; }
        public string? SecondaryColor { get; set; }
        public string? SpecialTeamsCoach { get; set; }
        public int? StadiumID { get; set; }
        [Required]
        public int TeamID { get; set; }
        public string? TertiaryColor { get; set; }
        public string? UpcomingOpponent { get; set; }
        public string? WikipediaLogoUrl { get; set; }
        public string? WikipediaWordMarkUrl { get; set; }
    }
}
