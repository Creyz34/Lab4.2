﻿using System;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B:");
            double b = Convert.ToDouble(Console.ReadLine());
        }
        static double pls(double A, double B)
        {
            return A + B;
        }
    }
}
