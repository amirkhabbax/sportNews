using Domain.Common;
using Domain.Enumerations;

namespace Domain.Sports_Related
{
    public class RankingTable : BaseEntity
    {

        public string LeagueId { get; set; }
        public League League { get; set; }

        public ESeason Season { get; set; }

        
        public string TeamId { get; set; }
        public Team Team { get; set; }

        public short MatchesPlayed { get; set; }

        public short Wons { get; set; }

        public short Losses { get; set; }

        public short Draws { get; set; }

        public short GoalsScored { get; set; }

        public short GoalsConceded { get; set; }

        public short Points { get; set; }

        public ETableType TableType{ get; set; } = ETableType.None;

        public RankingTable():base()
        {
        }
        
    }
}