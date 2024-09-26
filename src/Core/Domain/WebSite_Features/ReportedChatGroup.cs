using Domain.Common;
using Domain.WebSite_Features;
using SportNews.src.Core.Domain.Enumerations;

namespace SportNews.src.Core.Domain.WebSite_Features
{
    public class ReportedChatGroup: BaseEntity
    {
        public string CreatorUserId { get; set; }
        public User CreatorUser { get; set; }

        public string ChatUserGroupId { get; set; }
        public ChatUserGroup ChatUserGroup { get; set; }


        public List<ChatDetail> ReportedChatDetails { get; set; } = [];

        public EReportingReason ReportingReason { get; set; } = EReportingReason.None;
        public bool IsReviewed { get; set; } = false;

        public ReportedChatGroup():base()
        {
            
        }
    }
}
