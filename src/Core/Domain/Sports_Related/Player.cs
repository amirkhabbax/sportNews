using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Player : HumanBeing
    {

        public EFootballPost MainPost { get; set; } = EFootballPost.Other;

        public string? PlayablePosts { get; set; }

        public string MainFoot { get;}

        public string Height { get;}

        public string? HistoryId { get; set; }
        public History? History { get; set; }

        
        public string? CurrentTeamId { get; set; }
        public Team? CurrentTeam { get; set; }

        public string? HonorsList{ get; set; }

        public List<Team>? TeamsPlayed   { get; set; }  = new List<Team>();

        public Player()
        {
            super();
        }
        
    }
}