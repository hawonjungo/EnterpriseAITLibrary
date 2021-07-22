using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class CategoryModel
    {
        #region attributes
        private int cid;
        private string categoryName;
        #endregion
 
        #region properties
        public int CID
        {
            set { cid = value; }
            get { return cid; }
        }
        public string CategoryName
        {
            set { categoryName = value; }
            get { return categoryName; }
        }
        #endregion

        public static CategoryModel Parse(BookDS.TabCategoryRow categoryRow)
        {
            if (categoryRow == null)
                return null;

            CategoryModel category = new CategoryModel();
            category.CID = categoryRow.CID;
            category.CategoryName = categoryRow.CategoryName;
            return category;
        }
    }
}
