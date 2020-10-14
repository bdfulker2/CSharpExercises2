using System;
using NUnit.Framework;
using CSharpExcercises2;

namespace CSharpExercises2Tests
{
    [TestFixture]
    public class FindDaysOfMonthTests
    {
        [Test]
        [TestCase(2,2018, ExpectedResult = 28)]
        [TestCase(1, 2018, ExpectedResult = 31)]
        [TestCase(3, 2018, ExpectedResult = 31)]
        [TestCase(4, 2018, ExpectedResult = 30)]
        [TestCase(5, 2018, ExpectedResult = 31)]
        [TestCase(6, 2018, ExpectedResult = 30)]
        [TestCase(7, 2018, ExpectedResult = 31)]
        [TestCase(8, 2018, ExpectedResult = 31)]
        [TestCase(9, 2018, ExpectedResult = 30)]
        [TestCase(10, 2018, ExpectedResult = 31)]
        [TestCase(11, 2018, ExpectedResult = 30)]
        [TestCase(12, 2018, ExpectedResult = 31)]
        [TestCase(2, 2004, ExpectedResult = 29)]
        [TestCase(2, 1800, ExpectedResult = 28)]
        [TestCase(2, 1600, ExpectedResult = 29)]
        public int DaysOfMonthTest(int month, int year)
        {
            FindDaysOfMonth daysOfMonth = new FindDaysOfMonth();
            return daysOfMonth.DaysOfMonth(month, year);
        }
    }
}
