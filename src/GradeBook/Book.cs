using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            this.name=name;
            grades= new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
    
    
         var result= 0.0;
         var highest = double.MinValue;
         var lowest= double.MaxValue;
         foreach(var number in grades)
         {
             lowest=Math.Min(number,lowest);
             highest=Math.Max(number,highest);
             result+=number;
         }
         result/=grades.Count;
         Console.WriteLine($"the average grade is {result:N1}");
            Console.WriteLine($"the highest grade is {highest}");
            Console.WriteLine($"the lowest grade is {lowest}");
        }

        private List<double> grades;
       private string name;
    }
}
