using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Stadium : BaseEntity
    {
        public string CountryId { get; set; }
        public Country Country { get; set; }

        public string? TeamId { get; set; }
        public Team? Team { get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public short Capacity { get; set; }

        public byte[]? Picture   { get; set; }
        public Stadium()
        {
            super();
        }
    }
}