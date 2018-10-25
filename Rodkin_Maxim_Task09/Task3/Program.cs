using System;
using System.Collections.Generic;
using System.IO;

namespace Task3
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
                fileContent=fileContent.ToLower();
                var words = EditText.SelectWords(fileContent);
                Counter test = new Counter(words);
                foreach (var item in test.Words)
                {
                    Console.WriteLine($"{item.Key}     {item.Value}");
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
        }
    }
}
