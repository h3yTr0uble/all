using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle:Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double width;
        private double height;

        public Rectangle(int x, int y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public Rectangle(int x, int y):this(x, y, 1, 1)
        {

        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("Incorrect width");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Incorrect height");
                }
            }
        }

        public double Area
        {
            get
            {
                return width*height;
            }
        }

        public double Length
        {
            get
            {
                return 2*(width+height);
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw rectangle with width={width} and inner height={height}");
        }
    }
}
