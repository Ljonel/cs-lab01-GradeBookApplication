using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException();
            
            var twentyPercent = Students.Count * 0.2;
            //if()


            return base.GetLetterGrade(averageGrade);
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5) Console.WriteLine("Ranked grading requires at least 5 students");
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5) Console.WriteLine("Ranked grading requires at least 5 students");
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
