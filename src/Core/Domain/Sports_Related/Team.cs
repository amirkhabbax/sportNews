using Domain.Common;
using Domain.News_Related;

namespace Domain.Sports_Related
{
    public class Team : BaseEntity
    {

        public List<League>? ParticipatingLeagues { get; set;}  = [];

        public List<Player>? Squad { get; set;}  = [];

        public List<Team>? Rivals { get; set;}  = [];

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
        public Team():base()
        {
        }
    }
}