using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle:Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double radius;

        public Circle(int x, int y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Circle(int x, int y) : this(x, y, 1)
        {

        }

        public Circle() : this(0, 0, 1)
        {

        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Incorrect radius");
                }
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw circle with radius={Radius}");
        }
    }
}
