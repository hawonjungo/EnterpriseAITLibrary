using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class UserModel
    {
        #region attributes


        private int uID;
        private string userName;
        private string password;
        private int userLevel;
        private string userEmail;

        #endregion

        //properties
        public int UID
        {
            set { uID = value; }
            get { return uID; }
        }
        public string UserName
        {
            set { userName = value; /*extra code, whatever*/ }
            get { return userName; }
        }
        public string Password
        {
            set { password = value; /*extra code, whatever*/ }
            get { return password; }
        }
        public int UserLevel
        {
            set
            {
                if (value > -1)
                    userLevel = value;
            }
            get
            {
                return userLevel;
            }
        }
        public string UserEmail
        {
            set { userEmail = value; /*extra code, whatever*/ }
            get { return userEmail; }
        }

        //takes a row of data from our UserDataSet table and creates a UserModel object from it
        public static UserModel Parse(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
                return null;

            UserModel userModel = new UserModel();
            userModel.UID = userRow.UID;
            userModel.UserName = userRow.UserName;
            userModel.Password = userRow.Password;
            userModel.UserLevel = userRow.UserLevel;
            userModel.UserEmail = userRow.UserEmail;

            return userModel;
        }
    }
}
