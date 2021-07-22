using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class BookLogic
    {
        private BookDAO bookDAO;
        private BookDS.ViewBookDataTable bookTable;
        private BookDS.TabAuthorDataTable authorTable;
        private BookDS.TabLanguageDataTable languageTable;
        private BookDS.TabCategoryDataTable categoryTable;

        public BookLogic()
        {
            bookDAO = new BookDAO();
            bookTable = new BookDS.ViewBookDataTable();
            authorTable = new BookDS.TabAuthorDataTable();
            languageTable = new BookDS.TabLanguageDataTable();
            categoryTable = new BookDS.TabCategoryDataTable();
        }
        /* public BookDS.ViewBookDataTable ListBook()
        {
            //List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooks();
            return bookTable;
        } */
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
        public List<AuthorModel> ListAuthors()
        {
            List<AuthorModel> list = new List<AuthorModel>();
            authorTable = bookDAO.ListAuthors();

            AuthorModel author = new AuthorModel();
            author.AID = 0;
            author.AuthorName = "";
            list.Add(author);

            foreach (BookDS.TabAuthorRow row in authorTable.Rows)
            {
                author = AuthorModel.Parse(row);
                list.Add(author);
            }
            return list;
        }
        public List<LanguageModel> ListLanguages()
        {
            List<LanguageModel> list = new List<LanguageModel>();
            languageTable = bookDAO.ListLanguages();

            LanguageModel language = new LanguageModel();
            language.LID = 0;
            language.LanguageName = "";
            list.Add(language);
            
            foreach (BookDS.TabLanguageRow row in languageTable.Rows)
            {
                language = LanguageModel.Parse(row);
                list.Add(language);
            }
            return list;
        }
        public List<CategoryModel> ListCategories()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            categoryTable = bookDAO.ListCategories();

            CategoryModel category = new CategoryModel();
            category.CID = 0;
            category.CategoryName = "";
            list.Add(category);

            foreach (BookDS.TabCategoryRow row in categoryTable.Rows)
            {
                category = CategoryModel.Parse(row);
                list.Add(category);
            }
            return list;
        }
        public int AddNewBook(string ISBN, string bookName, int author, int category, int language, int publishYear, int pages, string publisher)
        {
            return bookDAO.InsertNewBook(ISBN, bookName, author, category, language, publishYear, pages, publisher);
        }
        public int AddNewCategory(string catName)
        {
            return bookDAO.InsertNewCategory(catName);
        }

        public int UpdateCategoryName(string catName, int cid)
        {
            return bookDAO.UpdateCategoryName(catName, cid);
        }
        public int DeleteCategory(int cid)
        {
            return bookDAO.DeleteCategory(cid);
        }
        public int AddReserved(int uid, string isbn, DateTime dateDDMMYY)
        {
            return bookDAO.AddReserved(uid, isbn, dateDDMMYY);
        }
    }
}
