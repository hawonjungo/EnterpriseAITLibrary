using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer9;

namespace BusinessLogic9
{
    public class LanguageModel
    {
        #region attributes
        private int lid;
        private string languageName;
        #endregion

        #region properties
        public int LID
        {
            set { lid = value; }
            get { return lid; }
        }
        public string LanguageName
        {
            set { languageName = value; }
            get { return languageName; }
        }
        /*public LanguageModel(int LID, string LanguageName)
        {
            lid = LID;
            languageName = LanguageName;
        } */
        #endregion

        public static LanguageModel Parse(BookDS.TabLanguageRow languageRow)
        {
            if (languageRow == null)
                return null;

            LanguageModel language = new LanguageModel();
            language.LID = languageRow.LID;
            language.LanguageName = languageRow.LanguageName;
            return language;
        }
    }
}
