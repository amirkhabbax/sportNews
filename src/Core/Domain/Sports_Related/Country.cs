using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Sports_Related
{
    public class Country : BaseEntity
    {
        public List<League> Leagues { get; set; } = new();
        public Continent Continent{ get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }
        public byte[]? Logo { get; set; }        
        public Country()
        {
            super();
        }
    }
}