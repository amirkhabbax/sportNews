using Domain.Common;

namespace SportNews.src.Core.Domain.WebSite_Features
{
    public class Comment : BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public byte[] CommentMessage {  get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEdited {  get; set; } 
        
        public string RepliedToCommentId { get; set; }
        public Comment? RepliedToComment { get; set; }

        public List<Comment> Comments { get; set; } =[];
        public List<Like> Likes { get; set; } = [];
        public List<DisLike> DisLikes { get; set; } = [];

        public Comment():base()
        {
            
        }
    }
}
