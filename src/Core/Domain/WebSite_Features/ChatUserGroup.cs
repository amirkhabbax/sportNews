using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.WebSite_Features
{
    public class ChatUserGroup : BaseEntity
    {
        public List<User>? Members { get; set; } = new List<User>();
        public List<User>? Administrators { get; set; } = new List<User>();
        public List<User>? CanWriteUsers { get; set; } = new List<User>();
        public List<User>? PendingRequests { get; set; } = new List<User>();
        public List<User>? BlockedUsers { get; set; } = new List<User>();

        public byte[]? ProfilePic { get; set; }

        public string? BioText { get; set; }
        
        public string ChatId { get; set; }
        public Chat Chat { get; set; }

        public bool IsGroup { get; set; } = false;
        public bool IsChannel { get; set; } = false;
        public bool IsPrivate { get; set; } = false;

        public string? CreatorUserId {get; set;}
        public User? CreatorUser {get; set;}

        public DateTime DateTimeCreated {get; set;}
        public ChatUserGroup()
        {
            super();
        }
    }
}