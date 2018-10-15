using System;

namespace Task2
{
    class Round
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double radius;

        public Round(int x, int y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Round(int x, int y) : this(x, y, 1)
        {

        }

        public Round() : this(0, 0, 1)
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

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public double Length
        {
            get
            {
                return Math.PI * 2 * radius;
            }
        }
    }
}
