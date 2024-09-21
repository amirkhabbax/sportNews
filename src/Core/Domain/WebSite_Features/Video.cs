using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.WebSite_Features
{
    public class Video : BaseEntity
    {
        public string? PostId { get; set; }
        public Post? Post { get; set; }
        
        public string? ChatDetailId { get; set; }
        public ChatDetail? ChatDetail { get; set; }

        public bool IsMain  { get; set; } = false;

        public string? VideoLink { get; set;}
        public string? VideoPath { get; set;}
        public string? AlternateText { get; set;}

        public short? Index { get; set; }
        public Video()
        {
            super();
        }
    }
}