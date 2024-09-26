using Domain.Common;
using Domain.News_Related;
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

        public List<Match>? Matches { get; set; } = [];
        public List<Team>? CurrentTeams { get; set; } = [];
        public List<RankingTable>? RankingTable { get; set; } = [];

        public List<Stat>? Stats { get; set; } = [];

        public byte[]? Logo { get; set; }
        public League():base()
        {
        }
        
    }
}