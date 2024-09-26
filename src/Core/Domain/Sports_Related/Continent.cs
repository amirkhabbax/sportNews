using Domain.Common;
using Domain.News_Related;

namespace Domain.Sports_Related
{
    public class Continent : BaseEntity
    {
        public List<Country> Countries { get; set; } =[];

        public List<League>? Leagues { get; set; } = [];

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public byte[]? Logo { get; set; }

        public Continent():base()
        {
        }
    }
}