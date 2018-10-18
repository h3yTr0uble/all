using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Canvas
    {
        public void DrawAll(IPrinter printer, List<Figure> figures)
        {
            foreach (var item in figures)
            {
                printer.Print(item);
            }
        }
    }
}
