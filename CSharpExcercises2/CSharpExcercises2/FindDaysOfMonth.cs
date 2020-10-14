using System;

namespace CSharpExcercises2
{
    public class FindDaysOfMonth
    {
        public int DaysOfMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
