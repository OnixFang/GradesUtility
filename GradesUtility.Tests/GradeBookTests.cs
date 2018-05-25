using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradesUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradesUtility.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        static void WriteResults(string description, float result)
        {
            Console.WriteLine($"{description}: {result}.");
        }

        static void WriteResults(string description, string result)
        {
            Console.WriteLine($"{description}: {result}.");
        }

        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90);
            book.AddGrade(89);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResults("Highest Grade", stats.HighestGrade);
            WriteResults("Expected value", 90);

            Assert.AreEqual(90, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90);
            book.AddGrade(89);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResults("Lowest Grade", stats.LowestGrade);
            WriteResults("Expected value", 89);

            Assert.AreEqual(89, stats.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90);
            book.AddGrade(89);
            book.AddGrade(78);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResults("Average Grade", stats.AverageGrade);
            WriteResults("Approximate expected value", 85.66f);

            Assert.AreEqual(85.66f, stats.AverageGrade, 0.01);
        }

        [TestMethod]
        public void ComputeLetterGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(80);
            book.AddGrade(85.4f);
            book.AddGrade(71);
            book.AddGrade(69);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine($"Average Grade: {stats.AverageGrade}, Letter Grade: {stats.LetterGrade}.");
            WriteResults("Expected value", "C");

            Assert.AreEqual("C", stats.LetterGrade);
        }
    }
}
