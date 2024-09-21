using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.WebSite_Features
{
    public class Chat : BaseEntity
    {
        public List<ChatDetail> ChatDetails { get; set; } = new List<ChatDetail>();

        public string ChatUserGroupId { get; set;}
        public ChatUserGroup ChatUserGroup { get; set; }

        public Chat()
        {
            super();
        }
    }
}