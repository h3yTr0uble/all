using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> test1 = new LinkedList<int>();
            List<int> test2 = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                test1.AddLast(i);
                test2.Add(i);
            }
            RemoveEachSecondItemLinkedList(test1);
            RemoveEachSecondItemList(test2);
            Console.ReadKey();
        }

        private static void RemoveEachSecondItemList<T>(List<T> list)
        {
            int i = 0;

            while (list.Count != 1)
            {
                if (i == list.Count-1)
                {
                    i = -1;
                }
                else
                {
                    if (i > list.Count - 1)
                    {
                        i = 0;
                    }
                }
                i++;
                list.RemoveAt(i);
            }
        }

        private static void RemoveEachSecondItemLinkedList<T>(LinkedList<T> list)
        {
            var delItem = list.First;
            while (list.Count > 1)
            {
                if (delItem.Next != null)
                {
                    list.Remove(delItem.Next);
                }
                else
                {
                    list.Remove(list.First);
                    delItem = list.First;
                    continue;
                }

                if (delItem.Next != null)
                {
                    delItem = delItem.Next;
                }
                else
                {
                    delItem = list.First;
                }
            }
        }

        public void RemoveEachSecondItem<T>(ICollection<T> list)
        {
            
        }
    }
}
