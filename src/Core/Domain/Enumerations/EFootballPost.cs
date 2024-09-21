namespace Domain.Enumerations
{
        public enum EFootballPost
        {
                Other = 0,

                #region GoalKeeper       
                GoalKeeper = 1,
                #endregion GoalKeeper

                #region Defenders
                RightBack = 2,
                LeftBack = 3,
                CenterBack = 45,
                RightCenterBack = 4,
                LefCenterBack = 5,
                #endregion Defenders

                #region Midfielders
                DefensiveMidfield = 6,
                RightMidfield = 7,
                CentralMidfield = 8,
                AttackingMidfield = 10,
                LeftMidfield = 11,
                #endregion Midfields

                #region Forwards
                RightWinger = 77,
                LeftWinger = 111,
                CenterForward = 9,
                SecondStriker = 99,
                #endregion Forwards

        }
}