﻿using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int N;
            if (int.TryParse(Console.ReadLine(), out N) && N >= 0)
            {
                for (int i = N; i > 0; i--)
                {
                    var str1 = new string(' ', i - 1);
                    str1 += '*';
                    var str2 = new string('*', (N - i) * 2);
                    str1 += str2;
                    Console.WriteLine(str1);
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
