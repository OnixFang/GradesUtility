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

            Console.WriteLine("Grades:");

            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResults("Highest Grade", stats.HighestGrade);
            WriteResults("Lowest Grade", stats.LowestGrade);
            WriteResults("Average Grade", stats.AverageGrade);
            WriteResults(stats.Description, stats.LetterGrade);
        }

        private static void WriteResults(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

        private static void WriteResults(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}
