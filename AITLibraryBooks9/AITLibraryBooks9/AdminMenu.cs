using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITLibraryBooks9
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnUserMaintenance_Click(object sender, EventArgs e)
        {
            //go to admin user maintenance form
            //create new thread that will call this function openUserAdminForm
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenUserAdminForm));
            t.Start();
            this.Close();
        }
        public static void OpenUserAdminForm()
        {
            Application.Run(new UserAdminMenu());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to admin category maintenance form
            //create new thread that will call this function openCategoryAdminForm
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenCategoryAdminForm));
            t.Start();
            this.Close();
        }
        public static void OpenCategoryAdminForm()
        {
            Application.Run(new CategoryAdminMenu());
        }

        private void btnBookMaintenance_Click(object sender, EventArgs e)
        {
            //go to admin book maintenance form
            //create new thread that will call this function openBookAdminForm
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookAdminForm));
            t.Start();
            this.Close();
        }
        public static void OpenBookAdminForm()
        {
            Application.Run(new BookAdminMenu());
        }
    }
}
