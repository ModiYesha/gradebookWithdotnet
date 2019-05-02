using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public void AddGrade(double grade) 
        {
            //List<double> grades; // local variable   
            grades.Add(grade); // Intialized not properly
        }     

        /*public Statiscs GetStatistic() {
            var result = new Statiscs();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            
            
        }*/
        List<double> grades = new List<double>();  
    }
}