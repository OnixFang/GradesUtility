using System;
using System.Collections.Generic;
using System.IO;
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
            SetGradeBookName(book);
            AddGradesToGradeBook(book);
            CreateGradesTextFile(book);
            WriteStatisticsResults(book);
        }

        private static void WriteStatisticsResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResults("Highest Grade", stats.HighestGrade);
            WriteResults("Lowest Grade", stats.LowestGrade);
            WriteResults("Average Grade", stats.AverageGrade);
            WriteResults(stats.Description, stats.LetterGrade);
        }

        private static void CreateGradesTextFile(GradeBook book)
        {
            using (StreamWriter outputfile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputfile);
            }
        }

        private static void AddGradesToGradeBook(GradeBook book)
        {
            book.AddGrade(97);
            book.AddGrade(80);
            book.AddGrade(94);
            book.AddGrade(75);
        }

        private static void SetGradeBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Please enter a name for your grade book:");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"The name has changed from {args.ExistingName} to {args.NewName}.");
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
