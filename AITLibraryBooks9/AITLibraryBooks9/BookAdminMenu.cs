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
    public partial class BookAdminMenu : Form
    {
        public BookAdminMenu()
        {
            InitializeComponent();
        }
        private void BookAdminMenu_Load(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();

            //show list of books in dataGridView
            List<BookModel> books = new List<BookModel>();
            books = bookLogic.ListBook();
            dataGridView1.DataSource = books;

            //set data source for Author combo box (Add option)
            comboAuthorAdd.DataSource = bookLogic.ListAuthors();
            //what to show in the list: Uses the string provided to look for an attribute of this name for each list item
            comboAuthorAdd.DisplayMember = "AuthorName";
            //what the value of this choice would be if we chose it 
            comboAuthorAdd.ValueMember = "AID";

            //set data source for Category combo box (Add option)
            comboCategoryAdd.DataSource = bookLogic.ListCategories();
            //what to show in the list: Uses the string provided to look for an attribute of this name for each list item
            comboCategoryAdd.DisplayMember = "CategoryName";
            //what the value of this choice would be if we chose it 
            comboCategoryAdd.ValueMember = "CID";

            //set data source for Language combo box (Add option)
            comboLanguageAdd.DataSource = bookLogic.ListLanguages();
            //what to show in the list: Uses the string provided to look for an attribute of this name for each list item
            comboLanguageAdd.DisplayMember = "LanguageName";
            //what the value of this choice would be if we chose it 
            comboLanguageAdd.ValueMember = "LID";

            // Do same for "Change" option
            comboAuthorChange.DataSource = bookLogic.ListAuthors();
            comboAuthorChange.DisplayMember = "AuthorName";
            comboAuthorChange.ValueMember = "AID";
            comboCategoryChange.DataSource = bookLogic.ListCategories();
            comboCategoryChange.DisplayMember = "CategoryName";
            comboCategoryChange.ValueMember = "CID";
            comboLanguageChange.DataSource = bookLogic.ListLanguages();
            comboLanguageChange.DisplayMember = "LanguageName";
            comboLanguageChange.ValueMember = "LID";
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Do some validation on the input data ...
            // ... here

            BookLogic bookLogic = new BookLogic();

            // Cross fingers at this point
            int status = bookLogic.AddNewBook(textBox3.Text,                    // ISBN
                            textBox1.Text,                                      // Book name
                            (Int32)comboAuthorAdd.SelectedValue,                // Author
                            (Int32)comboCategoryAdd.SelectedValue,              // Category
                            (Int32)comboLanguageAdd.SelectedValue,              // Language
                            Int32.Parse(textBox8.Text),                         // Publish year
                            Int32.Parse(textBox9.Text),                         // Number of pages
                            textBox10.Text);                                    // Publisher
            
            // Refresh the list of books
            dataGridView1.DataSource = bookLogic.ListBook();
            //return number of books inserted (0 or 1 - hopefully 1)
            return;
        }
    }
}
