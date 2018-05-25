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

            book.NameChanged += OnNameChanged;

            book.Name = "New Book";
            book.Name = "Ulises' grade book";

            book.AddGrade(97);
            book.AddGrade(80);
            book.AddGrade(94);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResults("Highest Grade", stats.highestGrade);
            WriteResults("Lowest Grade", stats.lowestGrade);
            WriteResults("Average Grade", stats.averageGrade);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"The name has changed from {args.ExistingName} to {args.NewName}.");
        }

        private static void WriteResults(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
