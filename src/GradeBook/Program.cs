using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(69.420);
            book.AddGrade(88.4);
            book.AddGrade(97.4);
            var stats = book.GetStatistics();
            System.Console.WriteLine($"The average grade is: {stats.Average:N1}\nThe max grade is: {stats.High}\nand the min grade is: {stats.Low}");
        }
    }
}
