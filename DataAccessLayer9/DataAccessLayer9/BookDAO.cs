using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BookDSTableAdapters;

namespace DataAccessLayer
{
    public class BookDAO
    {
        private BookDS bookDataSet;
        private ViewBookTableAdapter viewBookAdapter;
        private TabLanguageTableAdapter languageTableAdapter;
        private TabCategoryTableAdapter categoryTableAdapter;
        //if we need TabMediaTableAdapter, we'll add it later :/

        public BookDAO()
        {
            bookDataSet = new BookDS();
            viewBookAdapter = new ViewBookTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            categoryTableAdapter = new TabCategoryTableAdapter();
        }

        public BookDS.ViewBookDataTable ListBooks()
        {
            viewBookAdapter.Fill(bookDataSet.ViewBook);
            return bookDataSet.ViewBook;
        }
        public BookDS.ViewBookDataTable ListBooksByPublishYear(int publishYear)
        {
            viewBookAdapter.FillByPublishYear(bookDataSet.ViewBook, publishYear);
            return bookDataSet.ViewBook;
        }
        public BookDS.ViewBookDataTable ListBooksByCategoryName(string categoryName)
        {
            viewBookAdapter.FillByCategoryName(bookDataSet.ViewBook, categoryName);
            return bookDataSet.ViewBook;
        }
        public BookDS.ViewBookDataTable ListBooksByAuthorName(string authorName)
        {
            viewBookAdapter.FillByAuthorName(bookDataSet.ViewBook, authorName);
            return bookDataSet.ViewBook;
        }
        public BookDS.TabLanguageDataTable ListLanguages()
        {
            languageTableAdapter.Fill(bookDataSet.TabLanguage);
            return bookDataSet.TabLanguage;
        }
        public BookDS.TabCategoryDataTable ListCategories()
        {
            categoryTableAdapter.Fill(bookDataSet.TabCategory);
            return bookDataSet.TabCategory;
        }
    }
}
