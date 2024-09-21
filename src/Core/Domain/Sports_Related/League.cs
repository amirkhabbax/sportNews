using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class League : BaseEntity
    {
        public string? TagId { get; set; }
        public Tag? Tag { get; set; }


        public string? CountryId { get; set; }
        public Country? Country { get; set; }


        public string? ContinentId { get; set; }
        public Continent? Continent { get; set; }

        public List<Match>? Matches { get; set; } = new List<Match>();
        public List<Team>? CurrentTeams { get; set; } = new List<Team>();
        public List<RankingTable>? RankingTable { get; set; } = new List<RankingTable>();

        public List<Stat>? Stats { get; set; } = new List<Stat>();

        public byte[]? Logo { get; set; }
        public League()
        {
            super();
        }
        
    }
}