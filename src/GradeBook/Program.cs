using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main()
        {
            var book = new Book("Grade Book");
            while(true)
            {
                Console.WriteLine("Please Enter Grade Input\nPress q to quit:");
                var input = Console.ReadLine();
                if (input.Equals("q") || input.Equals("Q"))
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);                    
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("VERY NICE WHOOOHOO");
                }
            }
            var stats = book.GetStatistics();
            var letter = book.ComputeLetter(stats.Average);
            System.Console.WriteLine($"The average grade is: {stats.Average:N1}\nThe max grade is: {stats.High}\nThe min grade is: {stats.Low} and the letter grade is: {letter}");
        }
    }
}
