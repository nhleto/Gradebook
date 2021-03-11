﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.7, 13.2, 11} ;
            double result = 0.0;
            foreach (var item in numbers)
            {
                result += item;
            }
            System.Console.WriteLine(result);


            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
    }
}