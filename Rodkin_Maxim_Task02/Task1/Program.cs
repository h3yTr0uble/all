using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0;
            do
            {
                Console.WriteLine("Введите a:");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }
                Console.WriteLine("Введите b:");
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Значение не может быть отрицательным или раыным нулю");
                }
            } while (a <= 0 || b<=0);
            Console.WriteLine($"Площадь прямоугольника={a*b}");
            Console.ReadKey();
        }
    }
}
