using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        public List<Person> Persons { get; private set; } = new List<Person>();
        public void Add(Person person)
        {
            Console.WriteLine($"[{person.Name} came to work]");
            foreach (var item in Persons)
            {
                person.Came += item.SayHi;
            }
            person.OnCame();
            Persons.Add(person);
            Console.WriteLine();
        }

        public void Leave(Person person)
        {
            Console.WriteLine($"[{person.Name} left work]");
            Persons.Remove(person);
            foreach (var item in Persons)
            {
                person.Leave += item.SayBye;
                item.Came -= person.SayHi;
            }
            person.OnLeave();
            foreach (var item in Persons)
            {
                person.Leave -= item.SayBye;
            }
            Console.WriteLine();
        }
    }
}
