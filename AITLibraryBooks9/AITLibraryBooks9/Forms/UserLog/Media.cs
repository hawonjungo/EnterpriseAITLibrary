using AITLibraryBooks;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AITLibraryBooks9.Forms
{
    public partial class Media : Form
    {
        private Form currentChildForm;
        public int userLevel = CurrentUser.UserLevel;
        public Media()
        {
            InitializeComponent();

            hideSearch();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BookLogic bookLogic = new BookLogic();

            //set data source for data grid view
            dataGridView1.DataSource = bookLogic.ListBook();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //use the e arg to get info on which cell was clicked. We only care about the row.
            int row = e.RowIndex;
            if (row >= 0)
            {
                //Build a List from the data that's in the dataGridView
                List<BookModel> models = (List<BookModel>)dataGridView1.DataSource;
                //Now get the data from the specific row clicked
                BookModel book = models.ElementAt<BookModel>(row);
                //change label to show name of book clicked
                lblBookName.Text = book.BookName;
            }
        }
        private void hideSearch()
        {
            panel1.Visible = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void txtPublishYear_TextChanged(object sender, EventArgs e)
        {
            if(txtPublishYear.Text == "Public year")
            {
                txtPublishYear.Text = "";
                txtPublishYear.ForeColor = Color.Black;
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "Category Name")
            {
                txtCategoryName.Text = "";
                txtCategoryName.ForeColor = Color.Black;
            }
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthorName.Text == "Author Name")
            {
                txtAuthorName.Text = "";
                txtAuthorName.ForeColor = Color.Black;
            }
        }

        private void btnSearchYear_Click(object sender, EventArgs e)
        {
            if (txtPublishYear.Text != "")
            {
                BookLogic bookLogic = new BookLogic();
                try
                {
                    //find book based on what's typed into the publish year textbox
                    dataGridView1.DataSource = bookLogic.ListBookByPublishYear(Int32.Parse(txtPublishYear.Text));
                }
                catch (Exception ex)
                {
                    //if user typed in something that cannot be parsed into an int e.g "sdfsdf" then- 
                    dataGridView1.DataSource = bookLogic.ListBookByPublishYear(0); // enter zero for the year
                }
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                BookLogic bookLogic = new BookLogic();
                try
                {
                    //find book based on what's typed into the publish year textbox
                    dataGridView1.DataSource = bookLogic.ListBookByCategoryName(txtCategoryName.Text);
                }
                catch (Exception ex)
                {
                    //if user typed in something that is not a valid category name e.g "sdfsdf" then- 
                    dataGridView1.DataSource = bookLogic.ListBookByCategoryName(""); // enter null for the category name
                }
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.Text != "")
            {
                BookLogic bookLogic = new BookLogic();
                try
                {
                    //find book based on what's typed into the author name textbox
                    dataGridView1.DataSource = bookLogic.ListBookByAuthorName(txtAuthorName.Text);
                }
                catch (Exception ex)
                {
                    //if user typed in something that is not a valid category name e.g "sdfsdf" then- 
                    dataGridView1.DataSource = bookLogic.ListBookByAuthorName(""); // enter null for the category name
                }
            }
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
        private void Media_Load(object sender, EventArgs e)
        {
            labelUser.Text = CurrentUser.UserName;
            labelUser.Text = "User name: " + CurrentUser.UserName + "      userLevel: " + CurrentUser.UserLevel;
        }
    }
}
