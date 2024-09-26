using Domain.Common;
using Domain.WebSite_Features;

namespace SportNews.src.Core.Domain.WebSite_Features
{
    public class DisLike : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime DisLikingTime { get; set; }
        public string? CommentId { get; set; }
        public Comment? Comment { get; set; }

        public string? PostId { get; set; }
        public string? Post { get; set; }

        public DisLike() : base() { }
    }
}
