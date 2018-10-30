using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Library
{
    public class MathLibrary
    {
        public static int Pow(int x, int y)
        {
            var result = 1;
            for (int i = 1; i <= y; i++)
            {
                result *= x;
            }
            return result;
        }

        public static int Fact(int x)
        {
            var result = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
