using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9.BookDSTableAdapters;

namespace DataAccessLayer9
{
    public class BookDAO
    {
        private BookDS bookDataSet;
        private TabBookTableAdapter tabBookAdapter;
        private ViewBookTableAdapter viewBookAdapter;
        private TabAuthorTableAdapter authorTableAdapter;
        private TabLanguageTableAdapter languageTableAdapter;
        private TabCategoryTableAdapter categoryTableAdapter;
        private TabReservedTableAdapter reservedTableAdapter;

        public BookDAO()
        {
            bookDataSet = new BookDS();
            tabBookAdapter = new TabBookTableAdapter();
            viewBookAdapter = new ViewBookTableAdapter();
            authorTableAdapter = new TabAuthorTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            categoryTableAdapter = new TabCategoryTableAdapter();
            reservedTableAdapter = new TabReservedTableAdapter();
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
        public BookDS.TabAuthorDataTable ListAuthors()
        {
            authorTableAdapter.Fill(bookDataSet.TabAuthor);
            return bookDataSet.TabAuthor;
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
        public int InsertNewBook(string ISBN, string bookName, int author, int category, int language, int publishYear, int pages, string publisher)
        {
            //return number of books inserted (0-1 for this one)
            return tabBookAdapter.InsertBook(ISBN, bookName, author, category, language, publishYear, pages, publisher);
        }
        public int InsertNewCategory(string catName)
        {
            //return number of categories inserted (0-1 for this one)
            return categoryTableAdapter.InsertCategory(catName);
        }
        public int UpdateCategoryName(string catName, int cid)
        {
            //return number of category names updated (0-1 for this one)
            return categoryTableAdapter.UpdateCategory(catName, cid);
        }
        public int DeleteCategory(int cid)
        {
            //return number of category names deleted (0-1 for this one)
            return categoryTableAdapter.DeleteCategory(cid);
        }
        public int AddReserved(int uid, string isbn, DateTime dateDDMMYY)
        {
            //return number of reserves inserted (0-1 for this one, hopefully 1)
            return reservedTableAdapter.InsertReserved(uid, isbn, dateDDMMYY.ToString());
        }
    }
}
