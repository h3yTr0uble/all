using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0, N = 100;
            int[] mas = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(100) - 50;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    Sum += mas[i];
                }
            }
            Console.WriteLine($"Сумма неотрицательных элементов {Sum}");
            Console.ReadKey();
        }
    }
}
