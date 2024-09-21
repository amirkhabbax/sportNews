using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.News_Related
{
    public class Stat : BaseEntity
    {
        public string? HumanBeingId { get; set; }
        public HumanBeing? HumanBeing{ get; set; }
        
        public string? TeamId { get; set; }
        public Team? Team{ get; set; }

        public string? LeaugeId { get; set; }
        public Leauge? Leauge{ get; set; }

        public short Value { get; set; }

        public ESeason Season{ get; set; }

        public StatType StatType{ get; set; }

        public Stat()
        {
            super();
        }
    }
}