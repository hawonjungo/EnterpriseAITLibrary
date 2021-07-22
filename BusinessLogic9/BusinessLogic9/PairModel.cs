using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class PairModel
    {
        //shortcut to make attribute+property combo = type propfull, hit tab twice, fill in the blanks

        private int pairID; //attribute

        public int PairID //property to manage attribute
        {
            get { return pairID; }
            set { pairID = value; }
        }

        private string pairName;

        public string PairName
        {
            get { return pairName; }
            set { pairName = value; }
        }

    }
}
