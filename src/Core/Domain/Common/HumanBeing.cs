using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class HumanBeing : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public EGender Gender{ get; set; } = EGender.Other;

        public Date? BirthDate { get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public string? CountryId { get; set; }
        public Country? Country { get; set; }

        public byte[]? Picture { get; set; }

        public HumanBeing()
        {
            super();
        }
    }
}