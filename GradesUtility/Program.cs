using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(97);
            book.AddGrade(80);
            book.AddGrade(94);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Highest grade: " + stats.highestGrade);
            Console.WriteLine("Lowest grade:  " + stats.lowestGrade);
            Console.WriteLine("Average grade: " + stats.averageGrade);
        }
    }
}
