using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString test = new MyString();
            test.str.AddRange("a12dfsd123fsdfs123qqq");
            MyString test2 = new MyString();
            test2.str.AddRange("123");
            MyString result = test - test2;
            Console.WriteLine(result.ToString());
            
            Console.ReadKey();
        }
    }
}
