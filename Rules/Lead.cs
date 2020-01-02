using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Rules
{
    public class Lead
    {
        public int YearOfBirth;
        public int DayOfBirth;
        public int MonthOfBirth;
        public int YearFirst;
        public bool IsVeteran;


        public Lead(int year,int mon, int day,int first, bool veteran)
        {
            YearOfBirth = year;
            MonthOfBirth = mon;
            DayOfBirth = day;
            YearFirst = first;
            IsVeteran = veteran;
        }

        public bool IsBirthday()
        {
            return (this.DayOfBirth == 25 && this.MonthOfBirth == 11);
        }
    }
}
