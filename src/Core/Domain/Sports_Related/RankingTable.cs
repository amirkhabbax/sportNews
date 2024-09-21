using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class RankingTable : BaseEntity
    {

        public string LeaugeId { get; set; }
        public Leauge Leauge { get; set; }

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
        public RankingTable()
        {
            super();
        }
        
    }
}