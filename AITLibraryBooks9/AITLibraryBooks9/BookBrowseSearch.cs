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
    public partial class BookBrowseSearch : Form
    {
        string isbn;
        public BookBrowseSearch()
        {
            InitializeComponent();
        }

        private void BookBrowseSearch_Load(object sender, EventArgs e)
        {
            label2.Text = "User name: " + CurrentUser.UserName + "      userLevel: " + CurrentUser.UserLevel;
            BookLogic bookLogic = new BookLogic();
            //set data source for data grid view
            dataGridView1.DataSource = bookLogic.ListBook();
        }

        private void btnListAllBooks_Click(object sender, EventArgs e)
        {
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
                isbn = book.ISBN;                       // save the ISBN of the selected book
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnSearchAuthorName_Click(object sender, EventArgs e)
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

        private void btnReserveThis_Click(object sender, EventArgs e)
        {
            if (lblBookName.Text != "") {
                //List<ReservedModel>
                DateTime dateDDMMYY = DateTime.Today;
                BookLogic bookLogic = new BookLogic();
                int num = bookLogic.AddReserved(CurrentUser.UID, isbn, dateDDMMYY);
            }
        }
    }
}
