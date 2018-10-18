using System;

namespace Task2
{
    class Ring
    {
        private Round innerRound;
        private Round outerRound;

        public Ring(int x, int y, double radius, double innerRadius)
        {
            innerRound.X = x;
            innerRound.Y = y;
            innerRound.Radius = innerRadius;
            outerRound.Radius = radius;
        }

        public int X
        {
            get
            {
                return innerRound.X;
            }
        }

        public int Y
        {
            get
            {
                return innerRound.Y;
            }
        }

        public double OuterLingth
        {
            get
            {
                return outerRound.Length;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(outerRound.Radius, 2) - Math.PI * Math.Pow(innerRound.Radius, 2);
            }
        }

        public double InnerLength
        {
            get
            {
                return Math.PI * 2 * innerRound.Radius;
            }
        }
       
    }
}
