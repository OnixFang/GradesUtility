using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesUtility
{
    public class GradeStatistics
    {
        public float averageGrade;
        public float highestGrade;
        public float lowestGrade;

        public GradeStatistics()
        {
            averageGrade = 0;
            highestGrade = 0;
            lowestGrade = float.MaxValue;
        }
    }
}
