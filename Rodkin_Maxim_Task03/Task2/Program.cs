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
            int N = 10;
            int[,,] mas = new int[N, N, N];
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        mas[i, j, k] = rnd.Next(100) - 50;
                    }
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                        if (mas[i, j, k] > 0)
                        {
                            mas[i, j, k] = 0;
                        }
                        Console.WriteLine(mas[i, j ,k]);
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
