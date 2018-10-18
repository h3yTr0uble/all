using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class SizeOfPlayground
    {
        private int width;
        private int height;
        public int Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value>=10)
                {
                    width = value;
                }
                else
                {
                    throw new Exception("Incorrect width");
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value >= 10)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Incorrect height");
                }
            }
        }

        public SizeOfPlayground(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public SizeOfPlayground():this(10,10)
        { }
    }
}
