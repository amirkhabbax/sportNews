using Domain.Common;

namespace Domain.WebSite_Features
{
    public class ChatSeenByUser : BaseEntity
    {
        public string ChatId { get; set;}
        public ChatUserGroup Chat { get; set; }

        public string UserId { get; set;}
        public User User { get; set; }

        public DateTime LastSeen { get; set; }
        public ChatSeenByUser():base()
        {
        }
    }
}