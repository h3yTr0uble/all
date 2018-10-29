using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void MessageHi(string name, DateTime time);
    public delegate void MessageBye(string name);

    class Person
    { 
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
        }

        public event MessageHi Came;
        public event MessageBye Leave;

        
        public void OnCame()
        {
            Came?.Invoke(Name, DateTime.Now);
        }

        public void OnLeave()
        {
            Leave?.Invoke(Name);
        }

        public void SayHi(string name, DateTime time)
        {
            if (time.Hour<12)
            {
                Console.WriteLine($"Good morning, {name}, {Name} said.");
            }
            else
            {
                if (time.Hour >= 12 && time.Hour<17)
                {
                    Console.WriteLine($"Good afternoon, {name}, {Name} said.");
                }
                else
                {
                    Console.WriteLine($"Good evening, {name}, {Name} said.");
                }
            }
        }

        public void SayBye(string name)
        {
            Console.WriteLine($"Bye, {name}. {Name} said.");
        }
    }
}
