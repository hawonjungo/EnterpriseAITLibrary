using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BookLogic
    {
        private BookDAO bookDAO;
        private BookDS.ViewBookDataTable bookTable;
        private BookDS.TabLanguageDataTable languageTable;
        private BookDS.TabCategoryDataTable categoryTable;

        public BookLogic()
        {
            bookDAO = new BookDAO();
            bookTable = new BookDS.ViewBookDataTable();
            languageTable = new BookDS.TabLanguageDataTable();
            categoryTable = new BookDS.TabCategoryDataTable();
        }

        public List<BookModel> ListBook()
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooks();

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<BookModel> ListBookByPublishYear(int publishYear)
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooksByPublishYear(publishYear);

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<BookModel> ListBookByCategoryName(String categoryName)
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooksByCategoryName(categoryName);

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<BookModel> ListBookByAuthorName(String authorName)
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooksByAuthorName(authorName);

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<PairModel> ListLanguages()
        {
            List<PairModel> list = new List<PairModel>();
            languageTable = bookDAO.ListLanguages();
            foreach (BookDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
        public List<PairModel> ListCategories()
        {
            List<PairModel> list = new List<PairModel>();
            categoryTable = bookDAO.ListCategories();
            foreach (BookDS.TabCategoryRow row in categoryTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
    }
}
