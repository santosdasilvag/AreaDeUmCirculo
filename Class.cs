﻿using System;
using System.Diagnostics.Process;

class Program
{
    static void Main()
    {
        double raio = double.Parse(Console.ReadLine());

        double area = 3.14159 * Math.Pow(raio, 2);

        Console.WriteLine($"A={area:F4}");
    }
}
