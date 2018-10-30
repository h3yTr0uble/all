using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Employee empl1 = new Employee("a", "a", date, "a", date);
            Employee empl2 = new Employee("a", "a", date, "a", date);
            var a = empl1.Equals(empl2);
        }
    }
}
