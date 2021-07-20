using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BookModel
    {
        #region attributes

        private string bookId;
        private string bookName;
        private string publisher;
        private int bookPublishYear;
        private int pages;
        private string authorName;
        private string categoryName;
        private string languageName;

        #endregion
        #region properties
        public string BookID
        {
            set { bookId = value; }
            get { return bookId; }
        }
        public string BookName
        {
            set { bookName = value; }
            get { return bookName; }
        }
        public string Publisher
        {
            set { publisher = value; }
            get { return publisher; }
        }
        public int BookPublishYear
        {
            set { bookPublishYear = value; }
            get { return bookPublishYear; }
        }
        public int Pages
        {
            set { pages = value; }
            get { return pages; }
        }
        public string AuthorName
        {
            set { authorName = value; }
            get { return authorName; }
        }
        public string CategoryName
        {
            set { categoryName = value; }
            get { return categoryName; }
        }
        public string LanguageName
        {
            set { languageName = value; }
            get { return languageName; }
        }
        #endregion

        public static BookModel Parse(BookDS.ViewBookRow bookRow)
        {
            if (bookRow == null)
                return null;

            BookModel book = new BookModel();
            book.BookID = bookRow.ISBN;
            book.BookName = bookRow.BookName;
            book.Publisher = bookRow.Publisher;
            book.BookPublishYear = bookRow.PublishYear;
            book.Pages = bookRow.Pages;
            book.AuthorName = bookRow.AuthorName;
            book.CategoryName = bookRow.CategoryName;
            book.LanguageName = bookRow.LanguageName;

            return book;
        }
    }
}
