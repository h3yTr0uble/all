using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ConsolePrinter:IPrinter
    {
        public void Print(Figure f)
        {
            Console.WriteLine($"{f.GetType().Name}");
        }
    }
}
