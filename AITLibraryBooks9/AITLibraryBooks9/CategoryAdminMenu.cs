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
    public partial class CategoryAdminMenu : Form
    {
        int selectedCID;
        string selectedCategoryName;
        string newCategoryName;
        int previousRow = 0;
        public CategoryAdminMenu()
        {
            InitializeComponent();
        }
        private void CategoryAdminMenu_Load(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();

            //show list of books in dataGridView
            dataGridView1.DataSource = bookLogic.ListCategories();
        }

        private void btnCategoryAdminClose_Click(object sender, EventArgs e)
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
                List<CategoryModel> models = (List<CategoryModel>)dataGridView1.DataSource;
                //Now get the data from the specific row clicked
                CategoryModel cat = models.ElementAt<CategoryModel>(row);
                //save CID and CategoryName selected
                selectedCID = cat.CID;
                selectedCategoryName = cat.CategoryName;

                txtSelectedUser.Text = cat.CategoryName;

                DataGridViewRow rowSelected = dataGridView1.Rows[e.RowIndex];
                rowSelected.DefaultCellStyle.BackColor = Color.Aqua;
                previousRow = e.RowIndex;                               // Save the number of this row
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            // Do some validation on the input data ...
            // ... here

            BookLogic bookLogic = new BookLogic();

            // Cross fingers at this point
            int status = bookLogic.AddNewCategory(textBox3.Text);                                    // Publisher

            // Refresh the list of books
            dataGridView1.DataSource = bookLogic.ListCategories();
            //return number of categories inserted (0 or 1 - hopefully 1)
            return;
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();
            if (textBox4.Text != "") newCategoryName = textBox4.Text;

            // Cross fingers at this point
            bookLogic.UpdateCategoryName(newCategoryName, selectedCID);
            // Refresh the list of categories
            dataGridView1.DataSource = bookLogic.ListCategories();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();

            bookLogic.DeleteCategory(selectedCID);
            // Refresh the list of categories
            dataGridView1.DataSource = bookLogic.ListCategories();
        }
    }
}
