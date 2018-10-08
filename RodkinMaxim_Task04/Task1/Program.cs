using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            String str = Console.ReadLine();  
            Console.WriteLine(GetAvgLength(str));
            Console.ReadKey();
        }

        static public double GetAvgLength(string str)
        {
            char[] arr = str.ToCharArray();
            bool word = false;
            double sum = 0;
            int numWord = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetter(arr[i]) && word == false)
                {
                    numWord++;
                }
                if (char.IsLetter(arr[i]))
                {
                    word = true;
                    sum++;
                }
                else
                {
                    word = false;
                }
            }
            return sum / numWord;
        }
    }
}
