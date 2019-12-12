using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public class Helper
    {
        static public string EmptySpaceString = "                                            ";
        static public string centerString(string str, string insertString)
        {
            int middleNumInsertString = insertString.Length / 2;
            int middleNumStr = str.Length / 2;

            string firstPart = str.Substring(0, middleNumStr - middleNumInsertString);
            string secondPart = str.Substring(middleNumStr + middleNumInsertString);
            return firstPart + insertString + secondPart;
        }

    }
}
