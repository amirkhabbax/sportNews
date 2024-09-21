using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Manager : HumanBeing
    {
        public string? HistoryId { get; set; }
        public History? History { get; set; }
        
        public string? CurrentTeamId { get; set; }
        public Team? CurrentTeam { get; set; }

        public string? HonorsList   { get; set; }

        public List<Team>? TeamsManged   { get; set; }  = new List<Team>();
        public Manager()
        {
            super();
        }
    }
}