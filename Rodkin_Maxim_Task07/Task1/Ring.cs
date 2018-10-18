using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring:Figure
    {
        private Round innerRound=new Round();
        private Round outerRound=new Round();

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

        
        //private double innerRadius;
        //public double InnerRadius
        //{
        //    get
        //    {
        //        return innerRadius;
        //    }

        //    set
        //    {
        //        if (value > 0)
        //        {
        //            innerRadius = value;
        //            if (Radius < innerRadius)
        //            {
        //                innerRadius = Radius;
        //                Radius = value;
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("Incorrect radius");
        //        }
        //    }
        //}

        //public Ring(int x, int y, double radius, double innerRadius) : base(x, y, radius)
        //{
        //    InnerRadius = innerRadius;
        //}

        //public Ring(int x, int y) : base(x, y)
        //{
        //    innerRadius = 2;
        //}

        //public Ring() : this(0, 0)
        //{ }

        //public new double Area
        //{
        //    get
        //    {
        //        return Math.PI * Math.Pow(Radius, 2) - Math.PI * Math.Pow(innerRadius, 2);
        //    }
        //}

        //public double InnerLength
        //{
        //    get
        //    {
        //        return Math.PI * 2 * innerRadius;
        //    }
        //}

        //public override string Draw()
        //{
        //    return $"Draw ring with radius={Radius} and inner radius={innerRadius}";
        //}
    }
}
