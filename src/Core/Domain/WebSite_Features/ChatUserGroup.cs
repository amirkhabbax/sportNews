using Domain.Common;

namespace Domain.WebSite_Features
{
    public class ChatUserGroup : BaseEntity
    {
        public List<User>? Members { get; set; } = [];
        public List<User>? Administrators { get; set; } = [];
        public List<User>? CanWriteUsers { get; set; } = [];
        public List<User>? PendingRequests { get; set; } = [];
        public List<User>? BlockedUsers { get; set; } = [];

        public byte[]? ProfilePic { get; set; }

        public string? BioText { get; set; }

        public string ChatId { get; set; }
        public Chat Chat { get; set; }

        public bool IsGroup { get; set; } = false;
        public bool IsChannel { get; set; } = false;
        public bool IsPrivate { get; set; } = false;

        public string? CreatorUserId { get; set; }
        public User? CreatorUser { get; set; }

        public bool IsBanned { get; set; } = false;

        public DateTime DateTimeCreated { get; set; }

        public ChatUserGroup() : base()
        {
        }
    }
}