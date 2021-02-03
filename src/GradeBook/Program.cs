using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        { 
        var book=new Book("");
        book.AddGrade(80.8);
        book.AddGrade(90.8);
        book.AddGrade(10.8);
        book.ShowStatistics();
        
        }
    }
}
