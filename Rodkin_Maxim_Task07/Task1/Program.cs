﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new Line(0, 0, 1, 1);
            var circle = new Circle(0, 0, 4);
            var round = new Round(4, 4, 2);
            var ring = new Ring(1, 1, 3, 8);
            var rectangle = new Rectangle(1, 1, 5, 7);
            List<Figure> figures = new List<Figure>();
            figures.Add(line);
            figures.Add(circle);
            figures.Add(round);
            figures.Add(ring);
            figures.Add(rectangle);
            Figure.DrawAll(figures);
            Console.ReadKey();
        }
    }
}
