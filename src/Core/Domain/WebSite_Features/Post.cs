using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.WebSite_Features
{
    public class Post : BaseEntity
    {

        public Video? MainVideo {get; set;}

        public Picture? MainPicture {get; set;}
        public byte[] Text {get; set;}

        public List<Tag> Tags {get; set;}

        public EPostType PostType{get; set;} = EPostType.None;

        public string? CreatorUserId {get; set;}
        public User? CreatorUser {get; set;}

        public Date DateCreated {get; set;}

        public Match? Match {get; set;}

        public List<Picture> Pictures {get; set;} = new List<Picture>();
        public List<Video> Videos {get; set;} = new List<Video>();

        public Post()
        {
            super();
        }
    }
}