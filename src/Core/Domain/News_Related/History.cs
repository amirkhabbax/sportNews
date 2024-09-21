using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.News_Related
{
    public class History : BaseEntity
    {
        public string? HumanBeingId  { get; set; }
        public HumanBeing? HumanBeing { get; set; }

        public string? TeamId  { get; set; }
        public Team? Team { get; set; }

        public List<Stat> Stats { get; set; } = new List<Stat>();

        public History()
        {
            super();
        }
    }
}