using System;

namespace WhatADayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new DayGuesser();
            guesser.WelcomeText();
            guesser.AskUserForDateOfBirth();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}
