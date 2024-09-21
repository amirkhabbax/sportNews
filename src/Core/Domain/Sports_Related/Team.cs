using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Team : BaseEntity
    {

        public List<League>? ParticipatingLeagues { get; set;}  = new List<League>();

        public List<Player>? Squad { get; set;}  = new List<Player>();

        public List<Team>? Rivals { get; set;}  = new List<Team>();

        public string? CurrentManagerId { get; set; }
        public Manager? CurrentManager { get; set; }

        public string CountryId { get; set; }
        public Country Country { get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public string? HistoryId { get; set; }
        public History? History { get; set; }

        public byte[]? Logo { get; set; }
        public string? HonorsList { get; set; }
        public string? NickNames { get; set; }
        public Team()
        {
            super();
        }
    }
}