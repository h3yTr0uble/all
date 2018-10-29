using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate bool Compare(string str1, string str2);

        static void Main(string[] args)
        {
            string[] strings = { "fds", "gsddsgs", "fsdfs", "asd", "bft"};
            Sort(ref strings, SortByLength);
            
        }

        public static bool SortByLength(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                if (str1.CompareTo(str2)>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return str1.Length > str2.Length;
            }
        }

        public static void Sort(ref string[] strings, Compare comp)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (comp(strings[i], strings[j]))
                    {
                        var temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                }
            }
        }
    }
}
