using Domain.Common;
using Domain.WebSite_Features;

namespace SportNews.src.Core.Domain.WebSite_Features
{
    public class PostViewedByUser : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime ViewingTime { get; set; }

        public string? PostId { get; set; }
        public string? Post { get; set; }

        public PostViewedByUser():base() { }
    }
}
