using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class AuthorModel
    {
        #region attributes
        private int aid;
        private string authorName;
        #endregion

        #region properties
        public int AID
        {
            set { aid = value; }
            get { return aid; }
        }
        public string AuthorName
        {
            set { authorName = value; }
            get { return authorName; }
        }
        #endregion

        public static AuthorModel Parse(BookDS.TabAuthorRow authorRow)
        {
            if (authorRow == null)
                return null;

            AuthorModel author = new AuthorModel();
            author.AID = authorRow.AID;
            author.AuthorName = authorRow.AuthorName;
            return author;
        }
    }
}
