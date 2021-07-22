using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class ReservedModel
    {
        #region attributes
        private int rID;
        private int uID;
        private string isbn;
        private DateTime reservedDate;
        #endregion

        //properties
        public int RID
        {
            set { rID = value; }
            get { return rID; }
        }
        public int UID
        {
            set { uID = value; /*extra code, whatever*/ }
            get { return uID; }
        }
        public string ISBN
        {
            set { isbn = value; /*extra code, whatever*/ }
            get { return isbn; }
        }
        public DateTime ReservedDate
        {
            set { reservedDate = value; /*extra code, whatever*/ }
            get { return reservedDate; }
        }

        //takes a row of data from our BookDataSet table and creates a ReservedModel object from it
        public static ReservedModel Parse(BookDS.TabReservedRow reservedRow)
        {
            if (reservedRow == null)
                return null;

            ReservedModel reservedModel = new ReservedModel();
            reservedModel.RID = reservedRow.RID;
            reservedModel.UID = reservedRow.UID;
            reservedModel.ISBN = reservedRow.ISBN;
            reservedModel.ReservedDate = reservedRow.ReservedDate;

            return reservedModel;
        }
    }
}
