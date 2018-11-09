using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter file name:");
            var fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                var fileContent = File.ReadAllText(fileName);
                var strings = Regex.Split(fileContent, "\\W", RegexOptions.Multiline);
                List<string> numbers = new List<string>();
                foreach (var item in strings)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        numbers.Add((Math.Pow(double.Parse(item), 2)).ToString());
                    }
                }
                File.WriteAllLines(fileName, numbers);
                Console.WriteLine($"File {fileName} updated");
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}
