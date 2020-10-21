using System;

namespace CSharpExcercises2
{
    /// <summary>
    /// Create a function that takes the month and year (as integers) and returns the number of days in that month.
    /// Don't forget about leap years!
    /// Although you can create the algorithm to determine the leap-year number for February, there is a library function that can really help.
    /// </summary>
    public class FindDaysOfMonth
    {
        public int DaysOfMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public int DaysOfMonthNotUsingLibrary(int month, int year)
        {
            if (year % 4 == 0 && month == 2)
            {
                if (year % 100 == 0 && year % 400 != 0) return 28;
                else return 29;
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) return 31;
            else if (month == 2) return 28;
            else if (month == 4 || month == 6 || month == 9 || month == 11) return 30;
            else return 0;
        }
    }
}
