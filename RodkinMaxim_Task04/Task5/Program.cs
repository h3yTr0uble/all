using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Regex pattern = new Regex("<.*?>");
            str = pattern.Replace(str, "_");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
