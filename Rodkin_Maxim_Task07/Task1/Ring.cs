using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring:Round
    {
        private double innerRadius;
        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }

            set
            {
                if (value > 0)
                {
                    innerRadius = value;
                    if (Radius < innerRadius)
                    {
                        innerRadius = Radius;
                        Radius = value;
                    }
                }
                else
                {
                    throw new Exception("Incorrect radius");
                }
            }
        }

        public Ring(int x, int y, double radius, double innerRadius) : base(x, y, radius)
        {
            InnerRadius = innerRadius;
        }

        public Ring(int x, int y) : base(x, y)
        {
            innerRadius = 2;
        }

        public Ring() : this(0, 0)
        { }

        public new double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2) - Math.PI * Math.Pow(innerRadius, 2);
            }
        }

        public double InnerLength
        {
            get
            {
                return Math.PI * 2 * innerRadius;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw ring with radius={Radius} and inner radius={innerRadius}");
        }
    }
}
