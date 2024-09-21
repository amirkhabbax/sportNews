using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.WebSite_Features
{
    public class User : HumanBeing
    {
        public Date CreateDate  { get; set; }
        public Date LastDateChangedPassword  { get; set; }

        private string _userName;
        public string UserName { get { return _userName; } set { this._userName = value; } }

        private string _password;
        public string Password { get { return _password; } set { this._password = value; } }

        public string? BioText { get; set;}

        public List<Team>? FavoriteTeams { get; set; } = new List<Team>();
        public List<League>? FavoriteLeagues { get; set; } = new List<League>();

        public List<User>? Friends { get; set; } = new List<User>();
        public List<User>? BlockedUsers { get; set; } = new List<User>();

        public EUserType UserType { get; set; } = EUserType.None;
        
        public User(EUserType userType , Date createDate)
        {   
            CreateDate = createDate;
            LastDateChangedPassword = createDate;

            UserType = userType; 
            super();
        }
    }
}