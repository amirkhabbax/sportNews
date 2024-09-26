using Domain.Common;
using Domain.News_Related;

namespace Domain.Sports_Related
{
    public class Country : BaseEntity
    {
        public List<League> Leagues { get; set; } = [];
        public Continent Continent{ get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }
        public byte[]? Logo { get; set; }        
        public Country():base()
        {
        }
    }
}