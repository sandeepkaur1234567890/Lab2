﻿using System;
using Lab2.Particles;

namespace Lab2.Geometry2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonon p = new Phonon(1);
            Console.WriteLine(p);

            Point point = p.Position;
            point.SetCoords(100, 100);
            Console.WriteLine(p);
        }
    }
}
