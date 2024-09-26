using Domain.Common;
using Domain.Enumerations;
using Domain.News_Related;
using SportNews.src.Core.Domain.Enumerations;
using SportNews.src.Core.Domain.WebSite_Features;
using System.Text.RegularExpressions;

namespace Domain.WebSite_Features
{
    public class Post : BaseEntity
    {
        public int FavoritesCount { get; set; } = 0;
        public int LikesCount { get; set; } = 0;
        public int DisLikesCount { get; set; } = 0;
        public int ViewesCount { get; set; } = 0;
        public int CommentsCount { get; set; } = 0;

        public List<Like> Likes { get; set; } = [];
        public List<DisLike> DisLikes { get; set; } = [];
        public List<PostViewedByUser> ViewedByUsers { get; set; } = [];
        public List<Comment> Comments { get; set; } = [];


        public EPostState PostState { get; set; } = EPostState.None;
        public Video? MainVideo {get; set;}

        public Picture? MainPicture {get; set;}
        public byte[] Text {get; set;}

        public List<Tag> Tags {get; set;}

        public EPostType PostType{get; set;} = EPostType.Other;

        public string? CreatorUserId {get; set;}
        public User? CreatorUser {get; set;}

        public DateTime DateCreated {get; set;}

        public DateTime DatePublished { get; set; }

        public Match? Match {get; set;}

        public List<Picture> Pictures {get; set;} = [];
        public List<Video> Videos {get; set;} = [];

        public Post():base()
        {
        }
    }
}