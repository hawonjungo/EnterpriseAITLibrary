using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9.UserDSTableAdapters;

namespace DataAccessLayer9
{
    public class UserDAO
    {
        private UserDS userDataSet;
        private TabUserTableAdapter tabUserAdapter; //this class was autogenerated by our userDS query configure stage

        public UserDAO()
        {
            userDataSet = new UserDS();
            tabUserAdapter = new TabUserTableAdapter();
        }

        public UserDS.TabUserDataTable GetUserDataTable()
        {
            try
            {
                tabUserAdapter.FillAll(userDataSet.TabUser);//adapter helps fill our userDS for the TabUser table
                return userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                //dunno make it someone elses problem for now
                throw ex;
            }
        }

        public UserDS.TabUserDataTable GetUserByUserNamePassword(string userName, string password)
        {
            try
            {
                //use adapter to fill the TabUser table in the userDataSet using the FillByUserNamePassword method
                tabUserAdapter.FillByUserNamePassword(userDataSet.TabUser, userName, password);
                return userDataSet.TabUser;//return the table full of data
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertNewUser(string userName, string password, int userLevel, string email)
        {
            //return number of users inserted (0-1 for this one)
            return tabUserAdapter.InsertNewUser(userName, password, userLevel, email);
        }
        public int UpdatePassword(string password, int userID)
        {
            //returns number of users updated
            return tabUserAdapter.UpdatePassword(password, userID);
        }
        public int UpdateUserData(int userID, string password, int userLevel, string userEmail)
        {
            //returns number of users updated
            return tabUserAdapter.UpdateUserData(password, userLevel, userEmail, userID);
        }
        public int DeleteUserByUserID(int userID)
        {
            //returns number of users deleted
            return tabUserAdapter.DeleteUserByUserID(userID);
        }

    }
}
