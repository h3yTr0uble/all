using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }


        public Triangle(int a, int b, int c)
        {
            if (a>0 && b>0 && c>0 && a + b > c && b + c > a && a + c > b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("Incorrect length");
            }

        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double GetLength()
        {
            return A+B+C;
        }
    }
}
