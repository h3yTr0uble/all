using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int N;
            if (int.TryParse(Console.ReadLine(), out N) && N>=0)
            {
                for (int i = 1; i <= N; i++)
                {
                    var s = new string('*', i);
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное N");
            }
            Console.ReadKey();

        }
    }
}
