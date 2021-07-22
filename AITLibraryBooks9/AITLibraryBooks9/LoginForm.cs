using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic9;

namespace AITLibraryBooks9
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();

            //get users based on textbox entries
            List<UserModel> users = userLogic.GetListOfUsersByLogin(txtUsername.Text, txtPassword.Text);

            //if got some users
            if (users.Count > 0)
            {
                //keep track of current user details
                CurrentUser.UID = users[0].UID;
                CurrentUser.UserName = users[0].UserName;
                CurrentUser.UserLevel = users[0].UserLevel;

                //if admin user (userLevel 3) goto admin form
                if (users[0].UserLevel == 3)
                {
                    //go to admin form

                    //create new thread that will call this function openAdminForm
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));

                    t.Start();
                }
                else
                {
                    //go to student form
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaForm));

                    t.Start();
                }
                //either way, close this form off
                this.Close();
            }
            else
            {
                lblError.Text = "Login Error!";
            }

        }
        public static void OpenMediaForm()
        {
            Application.Run(new BookBrowseSearch());
        }

        public static void OpenAdminForm()
        {
            Application.Run(new DashBoard());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
