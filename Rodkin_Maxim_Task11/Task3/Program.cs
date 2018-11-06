using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoDPointWithHashList = new List<TwoDPointWithHash>();
            for (int i = -5000000; i < 5000000; i++)
            {
                twoDPointWithHashList.Add(new TwoDPointWithHash(i, i + 1000000));
            }
         //   Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", newPoint1.GetHashCode(), newPoint2.GetHashCode());
          //  var twoDPointWithHashList = new List<TwoDPointWithHash> { newPoint1, newPoint2 };
            List<int> hashList = new List<int>();
            foreach (var point in twoDPointWithHashList)
            {
                hashList.Add(point.GetHashCode());
            }
            var distinctTwoDPointWithHashList = twoDPointWithHashList.Distinct();
            var distinctHashList = hashList.Distinct();
            //    Console.WriteLine(distinctHashList.Count());
            //       Console.WriteLine(distinctTwoDPointWithHashList.Count());

            double countHash = distinctHashList.Count();
            double countPoints = distinctTwoDPointWithHashList.Count();
            Console.WriteLine($"Коллизия: {100-countHash / countPoints*100}%");

            Console.ReadKey();
        }
    }
}
