using Domain.Common;

namespace Domain.News_Related
{
    public class Tag : BaseEntity
    {
        public Tag():base()
        {
        }

        public List<Tag> RelatedTags { get; set; } = [];
    }
}