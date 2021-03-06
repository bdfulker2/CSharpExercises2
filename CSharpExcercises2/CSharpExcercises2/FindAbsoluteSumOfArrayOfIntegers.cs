﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpExcercises2
{
    /// <summary>
    /// Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
    /// The term "absolute value" means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).
    /// All the elements in the given array are integers.
    /// </summary>
    public class FindAbsoluteSumOfArrayOfIntegers
    {
        public int GetAbsoluteSum(int[] arrayOfIntegers)
        {
            int absoluteSum = 0;
            foreach(int i in arrayOfIntegers)
            {
                absoluteSum += Math.Abs(i);
            }
           
            return absoluteSum;
        }
    }
}
