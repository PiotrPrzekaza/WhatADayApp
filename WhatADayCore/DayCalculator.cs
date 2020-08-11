using System;
using System.Collections.Generic;
using System.Text;

namespace WhatADayCore
{
    public class DayCalculator
    {
        public DayOfWeek CalculateDayOfTheWeek(DateTimeOffset date)
        {
            var day = date.Day;
            var month = date.Month;
            var year = date.Year;

            var daysList = new List<int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            year -= month < 3 ? 1 : 0;

            var calculateValue = (year + year / 4 - year / 100 + year / 400 + daysList[month - 1]+ day)%7;

            return (DayOfWeek)(calculateValue - 1);
        }
    }
}
