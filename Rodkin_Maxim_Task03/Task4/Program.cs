using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int[,] mas = new int[N, N];
            int Sum = 0;
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int k = 0; k < mas.GetLength(1); k++)
                {
                    mas[i, k] = rand.Next(100);
                    if ((i + k) % 2 == 0)
                    {
                        Sum += mas[i, k];
                    }
                }
            }
            Console.WriteLine($"Cумма элементов массива, стоящих на чётных позициях = {Sum}");
            Console.ReadKey();


        }
    }
}
