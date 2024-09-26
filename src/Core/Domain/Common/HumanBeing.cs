using Domain.Enumerations;
using Domain.News_Related;
using Domain.Sports_Related;

namespace Domain.Common
{
    public abstract class HumanBeing : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public EGender Gender{ get; set; } = EGender.Other;

        public DateTime? BirthDate { get; set; }

        public string? TagId { get; set; }
        public Tag? Tag { get; set; }

        public string? CountryId { get; set; }
        public Country? Country { get; set; }

        public byte[]? Picture { get; set; }

        public HumanBeing():base()
        {
        }
    }
}