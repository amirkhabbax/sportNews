using Domain.Common;
using Domain.Sports_Related;

namespace Domain.News_Related
{
    public class History : BaseEntity
    {
        public string? HumanBeingId  { get; set; }
        public HumanBeing? HumanBeing { get; set; }

        public string? TeamId  { get; set; }
        public Team? Team { get; set; }

        public List<Stat> Stats { get; set; } = [];

        public History():base()
        {
        }
    }
}