using System;

namespace Task2
{
    class Program
    {
        public static void Main()
        {
            var source = @"D:\epam\course\Rodkin_Maxim_Task11\";
            var target = @"D:\epam\course\test\";
            Console.WriteLine("1: Start logging");
            Console.WriteLine("2: Rollback");
            var str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Console.WriteLine("Press \'q\' to quit.");
                    Watcher.Run(source, target, EndWhile);
                    break;
                case "2":
                    Console.WriteLine("Enter date and time");
                    var date = Console.ReadLine();
                    Watcher.Rollback(source, target, date);
                    break;
                default:
                    break;
            }
        }

        public static bool EndWhile()
        {
            return Console.Read() != 'q';
        }
      
    }
}
