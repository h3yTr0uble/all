using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw figure");
        }

        static public void DrawAll(List<Figure> figures)
        {
            foreach (var item in figures)
            {
                item.Draw();
            }
        }
    }
}
