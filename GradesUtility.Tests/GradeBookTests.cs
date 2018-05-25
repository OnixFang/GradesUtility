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
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90);
            book.AddGrade(89);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90);
            book.AddGrade(89);

            GradeStatistics stats = book.ComputeStatistics();

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

            Assert.AreEqual(85.66f, stats.AverageGrade, 0.01);
        }
    }
}
