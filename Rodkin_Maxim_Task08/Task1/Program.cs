using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> test1 = new DynamicArray<int>();
            for (int i = 0; i < 5; i++)
            {
                test1.Add(i);
            }
            for (int i = 0; i < test1.Capacity; i++)
            {
                Console.WriteLine(test1[i]);
            }
            Console.WriteLine();
            test1.Insert(8, 3);
            for (int i = 0; i < test1.Capacity; i++)
            {
                Console.WriteLine(test1[i]);
            }
            Console.ReadKey();
        }
    }
}
