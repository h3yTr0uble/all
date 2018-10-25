using System;
using System.Text.RegularExpressions;

namespace Task3
{
    class EditText
    {
        public static string[] SelectWords(string str)
        {
            var words = Regex.Split(str, "\\W", RegexOptions.Multiline);
            return words;
        }
    }
}
