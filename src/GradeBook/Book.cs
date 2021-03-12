using System;
using System.Collections.Generic;

namespace GradeBook
{
    //add public class is needed if tests fail ??
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public char ComputeLetter(double grade)
        {
            char letter;
            switch (grade)
            {
                case var d when d >= 90.0:
                    letter = 'A';
                    break;

                case var d when d >= 80.0:
                    letter = 'B';
                    break;

                case var d when d >= 70.0:
                    letter = 'C';
                    break;

                case var d when d >= 60.0:
                    letter = 'D';
                    break;
                                                        
                default:
                    letter = 'F';
                    break;
            }
            var stats = new Statistics();
            stats.letter = letter;
            return stats.letter;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
                result.Low = Math.Min(grade, result.High);
            }
            result.Average /= grades.Count;
            return result;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 || grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid grade {nameof(grade)}!");
            }
        }
        private List<double> grades;
        public string Name;
    }
}