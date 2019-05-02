using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] numbers = new [] {12.7, 10.0, 11.0, 16.3 } ;//defining a var/double 
            // List<double> grades = new List<double>(); // () says I am invoking the method to create a list of double

            var book = new Book();
            book.AddGrade(89.1);

            /* Lecture: 2 
            var grades = new List<double>() {12.7, 10.0, 11.0, 16.3  }; // Implicit typing now using var
            grades.Add(12.7);
            var result = 0.0;
            foreach(var number in grades) {
                result += number;
            }
            result = result / grades.Count;
            Console.WriteLine($"The Avg grade is {result:N3}");
            */
            
            /* 1st Lecture:
            if(args.Length > 0) {
                Console.WriteLine($"Hello Beautiful, {args[0]} !");
            }
            else {
                Console.WriteLine ("Hello!!");
            }*/
        }
    }
}
