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
    public partial class UserAdminMenu : Form
    {
        int selectedUserID;
        string selectedUserName;
        string selectedUserPassword;
        int selectedUserLevel;
        string selectedUserEmail;
        int previousRow = 0;            // Row previously selected in dataGridView1

        public UserAdminMenu()
        {
            InitializeComponent();
        }
        private void UserAdminMenu_Load(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();

            //set data source for data grid view
            dataGridView1.DataSource = userLogic.GetListOfUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //use the e arg to get info on which cell was clicked. We only care about the row.
            int row = e.RowIndex;
            if (row >= 0)
            {
                // If we already have a row selected (from previous click) then reset its background colour
                DataGridViewRow previousRowSelected = dataGridView1.Rows[previousRow];
                previousRowSelected.DefaultCellStyle.BackColor = Color.White;

                //Build a List from the data that's in the dataGridView
                List<UserModel> models = (List<UserModel>)dataGridView1.DataSource;
                //Now get the data from the specific row clicked
                UserModel user = models.ElementAt<UserModel>(row);
                //save ID and name of user selected
                selectedUserID = user.UID;
                selectedUserName = user.UserName;
                selectedUserPassword = user.Password;
                selectedUserLevel = user.UserLevel;
                selectedUserEmail = user.UserEmail;

                txtSelectedUser.Text = user.UserName;
                
                DataGridViewRow rowSelected = dataGridView1.Rows[e.RowIndex];
                rowSelected.DefaultCellStyle.BackColor = Color.Aqua;
                previousRow = e.RowIndex;                               // Save the number of this row
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go back to admin form

            //create new thread that will call this function openAdminForm
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));

            t.Start();
            this.Close();
        }
        public static void OpenAdminForm()
        {
            Application.Run(new AdminMenu());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();

            // Cross fingers at this point
            userLogic.AddNewUser(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), textBox4.Text);
            // Refresh the list of users
            dataGridView1.DataSource = userLogic.GetListOfUsers();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();
            if (textBox5.Text != "") selectedUserPassword = textBox5.Text;
            if (textBox6.Text != "") selectedUserLevel = Int32.Parse(textBox6.Text);
            if (textBox7.Text != "") selectedUserEmail = textBox7.Text;

            // Cross fingers at this point
            userLogic.UpdateUserData(selectedUserID, selectedUserPassword, selectedUserLevel, selectedUserEmail);
            // Refresh the list of users
            dataGridView1.DataSource = userLogic.GetListOfUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();

            userLogic.DeleteUserByUserID(selectedUserID);
            // Refresh the list of users
            dataGridView1.DataSource = userLogic.GetListOfUsers();
        }


    }
}
