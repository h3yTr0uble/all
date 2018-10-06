using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum=0, N = 1000;
            for (int i = 1; i < N; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"Сумма={Sum}");
            Console.ReadKey();
        }
    }
}
