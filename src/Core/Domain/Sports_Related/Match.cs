using Domain.Common;
using Domain.Enumerations;
using Domain.News_Related;

namespace Domain.Sports_Related
{
    public class Match : BaseEntity
    {
        public EMatchType MatchType{ get; set; }

        public string HostTeamId { get; set; }
        public Team HostTeam { get; set; }
        public short HostTeamScore { get; set; } = 0;

        public string GuestTeamId { get; set; }
        public Team GuestTeam { get; set; }
        public short GuestTeamScore { get; set; } = 0;

        public string LeagueId { get; set; }    
        public League League    { get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public ESeason Season { get; set; }

        public DateTime DateTime{ get; set; }

        public string StadiumId { get; set; }
        public Stadium Stadium { get; set; }

        public Refree? FirstRefree { get; set; }
        public Refree? FourthRefree { get; set; }
        public List<Refree>? AssistantRefrees { get; set; } = new List<Refree>();
        public List<Refree>? VideoAssistantRefrees { get; set; } = new List<Refree>();

        public Match():base()
        {
        }
    }
}