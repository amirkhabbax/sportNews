using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.WebSite_Features
{
    public class Picture : BaseEntity
    {
        public string? PostId { get; set; }
        public Post? Post { get; set; }
        
        public bool IsMain  { get; set; } = false;

        public string? PictureLink { get; set;}
        public string? PicturePath { get; set;}
        public string? AlternateText { get; set;}

        public short? Index { get; set; }
        public Picture():base()
        {
        }
    }
}