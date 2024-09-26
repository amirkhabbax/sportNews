using Domain.Common;
using Domain.WebSite_Features;
using SportNews.src.Core.Domain.Enumerations;

namespace SportNews.src.Core.Domain.WebSite_Features
{
    public class ReportedPost: BaseEntity
    {
        public string CreatorUserId { get; set; }
        public User   CreatorUser { get; set; }

        public string PostId { get; set; }
        public Post Post { get; set; }

        public EReportingReason ReportingReason { get; set; } = EReportingReason.None;
        public bool IsReviewed { get; set; } = false;
        public ReportedPost():base() { }
    }
}
