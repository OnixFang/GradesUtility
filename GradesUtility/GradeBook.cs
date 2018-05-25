using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesUtility
{
    public class GradeBook
    {
        private List<float> grades;

        private string _name;

        public event NameChangedDelegate NameChanged;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }

                    _name = value;
                }
            }
        }

        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeBook(string name)
        {
            Name = name;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                stats.highestGrade = Math.Max(grade, stats.highestGrade);
                stats.lowestGrade = Math.Min(grade, stats.lowestGrade);
                sum += grade;
            }

            stats.averageGrade = sum / grades.Count;

            return stats;
        }
    }
}