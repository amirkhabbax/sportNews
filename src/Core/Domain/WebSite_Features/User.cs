using Domain.Common;
using Domain.Enumerations;
using Domain.Sports_Related;

namespace Domain.WebSite_Features
{
    public class User : HumanBeing
    {
        public DateTime CreateDate  { get; set; }
        public DateTime LastDateChangedPassword  { get; set; }

        private string _userName;
        public string UserName { get { return _userName; } set { this._userName = value; } }

        private string _password;
        public string Password { get { return _password; } set { this._password = value; } }

        public string? BioText { get; set;}

        public List<Team>? FavoriteTeams { get; set; } = [];
        public List<League>? FavoriteLeagues { get; set; } = [];

        public List<Post>? FavoritePosts { get; set; } = [];

        public List<User>? Friends { get; set; } = [];
        public List<User>? PendingFriendRequests { get; set; } =[];

        public List<User>? BlockedUsers { get; set; } = [];

        public EUserType UserType { get; set; } = EUserType.None;
        
        public User(EUserType userType , DateTime createDate):base()
        {   
            CreateDate = createDate;
            LastDateChangedPassword = createDate;

            UserType = userType; 
        }
    }
}