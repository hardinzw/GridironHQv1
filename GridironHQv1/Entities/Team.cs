using System.ComponentModel;
using System.Runtime.Serialization;

namespace GridironHQv1.Entities
{
    public class Team
    {
        [Description("Abbreviation of the team (e.g. SD, PHI, NE, IND, etc.)")]
        [DataMember(Name = "Key", Order = 1)]
        public string Key { get; set; }

        [Description("The auto-generated unique ID of the Team.")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        [Description("The auto-generated unique ID of the Team, that avoids collisions with PlayerIDs.  This is useful when combining players and fantasy defenses to create fantasy teams.")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        [Description("The city/location of the team (e.g. San Diego, Philadelphia, New England, Indianapolis, etc.)")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        [Description("The mascot of the team (e.g. Chargers, Eagles, Patriots, Colts, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        [Description("The conference of the team (e.g. AFC or NFC)")]
        [DataMember(Name = "Conference", Order = 6)]
        public string Conference { get; set; }

        [Description("The division of the team (e.g. East, North, South, West)")]
        [DataMember(Name = "Division", Order = 7)]
        public string Division { get; set; }

        [Description("The full name of the team (e.g. New England Patriots)")]
        [DataMember(Name = "FullName", Order = 8)]
        public string FullName { get; set; }

        [Description("The current head coach of the team")]
        [DataMember(Name = "HeadCoach", Order = 13)]
        public string HeadCoach { get; set; }
    }
}
