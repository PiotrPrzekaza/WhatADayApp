using System;
using WhatADayCore;

namespace WhatADayApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }
        public DateTimeOffset UserDateOfBirth { get; set; }
        public DayOfWeek UserDayOfWeek { get; set; }

        public void WelcomeText()
        {
            Console.WriteLine("------ Hi, I am a program that calculates the day of the week you were born based on your date of birth!!! ------");
            Calculator = new DayCalculator();
        }

        public void AskUserForDateOfBirth()
        {
            Console.WriteLine("Enter your date of birth, please: ");
            var userData = Console.ReadLine();
            var succeded = DateTimeOffset.TryParse(userData, out var date);

            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }
            Console.WriteLine("The date format was wrong. Use mm/dd/yyyy please.");
            AskUserForDateOfBirth();
        }

        public void CalculateDayOfTheWeek()
        {
            if(UserDateOfBirth  == null)
            {
                Console.WriteLine("I can't calculate day of birth without date. Please check you date of birth.");
                return;
            }
             UserDayOfWeek =  Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("A day of week, You are born is - " + UserDayOfWeek);
        }
    }
}
