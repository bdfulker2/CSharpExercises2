using System;
using NUnit.Framework;

namespace CSharpExercises2Tests
{
    [TestFixture]
    public class FindDaysOfMonthTests
    {
        [Test]
        [TestCase(2,2018, ExpectedResult = 28)]
        public int DaysOfMonthTest(int month, int year)
        {
            return DaysOfMonth(month, year);
        }
    }
}
