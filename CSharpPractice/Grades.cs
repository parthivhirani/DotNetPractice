using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Grades
    {
        public Grades()
        {
            grades = new List<double>();
        }
        public void AddGrades(double grade)
        {
            grades.Add(grade);
        }
        public void displayGrade()
        {
            foreach (double g in grades)
            {
                Console.WriteLine(g);
            }
        }
        List<double> grades; // default access modifier
    }
}
