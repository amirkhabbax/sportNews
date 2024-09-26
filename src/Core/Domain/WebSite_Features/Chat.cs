using Domain.Common;

namespace Domain.WebSite_Features
{
    public class Chat : BaseEntity
    {
        public List<ChatDetail> ChatDetails { get; set; } = [];

        public string ChatUserGroupId { get; set;}
        public ChatUserGroup ChatUserGroup { get; set; }

        public Chat():base()
        {
        }
    }
}