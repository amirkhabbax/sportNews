using Domain.Common;
using SportNews.src.Core.Domain.WebSite_Features;

namespace Domain.WebSite_Features
{
    public class ChatDetail : BaseEntity
    {
        public string? MessageText { get; set; }
        public string? ChatDetailFileId { get; set; }
        public ChatDetailFile? ChatDetailFile { get; set; }

        public string ChatId { get; set; }
        public Chat Chat { get; set; }
        
        public string? RepliedToChatDetailId { get; set; }
        public ChatDetail? RepliedToChatDetail  { get; set; }

        public User MessageOwner { get; set; }

        public DateTime MeassgeSentDateTime { get; set; }

        public bool IsEdited { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        public bool IsBanned { get; set; } = false;


        public ChatDetail():base()
        {
        }
    }
}