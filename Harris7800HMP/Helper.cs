namespace Harris7800HMP
{
    public class Helper
    {
        public static string emptySpaceString = "                                            ";
        public static string CenterString(string str, string insertString)
        {
            var middleNumInsertString = insertString.Length / 2;
            var middleNumStr = str.Length / 2;

            var firstPart = str.Substring(0, middleNumStr - middleNumInsertString);
            var secondPart = str.Substring(middleNumStr + middleNumInsertString);
            return firstPart + insertString + secondPart;
        }

        public static int CalcCenterIndent(int textLength, int lineLength)
        {
            var midTextLength = textLength / 2;
            var midLineLength = lineLength / 2;

            return midLineLength - midTextLength;
        }

    }
}
