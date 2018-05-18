using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradesUtility.Tests.Types
{
    [TestClass]
    public class TypesTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(87.3f, grades[0]);
        }

        private void AddGrades(float[] grades)
        {
            grades[0] = 87.3f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "Ulises";

            name = name.ToUpper();

            Assert.AreEqual("ULISES", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 1, 1);

            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 100;

            ModifyNumber(x);

            Assert.AreEqual(100, x);
        }

        private void ModifyNumber(int number)
        {
            number =+ 10;
        }

        [TestMethod]
        public void ReferenceTypesPassByReference()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveNameToGradeBook(book2);

            Assert.AreEqual("A Grade Book", book1.Name);
        }

        private void GiveNameToGradeBook(GradeBook book)
        {
            book.Name = "A Grade Book";
        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "Ulises";
            string name2 = "ulises";

            bool result = String.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1++;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            book1.Name = "Ulises' gradebook";

            Assert.AreEqual(book1.Name, book2.Name);
        }
    }
}
