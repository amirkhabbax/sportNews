using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Continent : BaseEntity
    {
        public List<Country> Countries { get; set; } = new();

        public List<League>? Leagues { get; set; } = new();

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public byte[]? Logo { get; set; }

        public Continent()
        {
            super();
        }
    }
}