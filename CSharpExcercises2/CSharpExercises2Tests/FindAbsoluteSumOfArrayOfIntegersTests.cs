using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharpExcercises2;

namespace CSharpExercises2Tests
{
    [TestFixture]
    public class FindAbsoluteSumOfArrayOfIntegersTests
    {
        [Test]
        [TestCase(new int[] { 2, -1, -3, 4, 8 }, ExpectedResult = 18)]
        [TestCase(new int[] { -1 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -3, -5, -4, -10, 0 }, ExpectedResult = 23)]
        [TestCase(new int[] { 8, 9, 10, 32, 101, -10 }, ExpectedResult = 170)]
        [TestCase(new int[] { 500 }, ExpectedResult = 500)]
        public int GetAbsoluteSum(int[] arrayOfInteger = null)
        {
            FindAbsoluteSumOfArrayOfIntegers absoluteSum = new FindAbsoluteSumOfArrayOfIntegers();
            return absoluteSum.GetAbsoluteSum(arrayOfInteger);
        }
    }
}
