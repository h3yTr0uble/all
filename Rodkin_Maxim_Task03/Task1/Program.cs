using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100;
            int[] mas = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(100) - 50;
            }
            DisplayArray(mas);
            Console.WriteLine($"Максимальное значение: {Max(mas)}");
            Console.WriteLine($"Минимальное значение: {Min(mas)}");
            Sort(mas);
            DisplayArray(mas);
            Console.ReadKey();
        }

        static public void DisplayArray(int[] mas)
        {
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }

        static public int Max(int[] mas)
        {
            int max = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }
            return max;
        }

        static public int Min(int[] mas)
        {
            int min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
            }
            return min;
        }

        static public void Sort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
        }
    }
}
