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
            this.name = name;
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
            grades.Add(grade);
        }
        private List<double> grades;
        private string name;
    }
}