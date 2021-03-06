﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    /* 
         Make a method called AgeCalculator
         The method will have one input parameter, your birthday date
         The method should return your age
         Show the age of a user after he inputs a date
         Note: take into consideration if the birthday is today, after or before today  
        */

    class Program
    {
        static DateTime AgeCalculator(DateTime date)
        {
            DateTime age = DateTime.Now;
            age = age.AddYears(-(date.Year));
            age = age.AddDays(-(date.Day));
            age = age.AddMonths(-(date.Month));

            return age;
        }

        
        static bool RunProgramAgain()
        {
            bool check;
            string input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                check = true;
            }
            else if (input == "N" || input == "n")
            {
                check = false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                check = RunProgramAgain();
            }
            return check;
        }
        
        static DateTime ParseDate ()
        {
            string birthDate = Console.ReadLine();

            DateTime convertedDate;
            bool check = DateTime.TryParse(birthDate, out convertedDate);

            if (!check)
            {
                Console.WriteLine("Please enter valid date");
                convertedDate = ParseDate();
            }
            return convertedDate;
        }

        static void Main()
        {
            bool RunProgram = true;

            do
            {
                Console.WriteLine("Please insert your birth date in the folowing format (year, month, day)");

                DateTime age = AgeCalculator(ParseDate());

                Console.WriteLine($"You are {age.Year} years, {age.Month} month and {age.Day} day old");
                Console.WriteLine("__________________________________________________________________");
                Console.Write("Do you want to calculate another age Y / N ? ");
                RunProgram = RunProgramAgain();

            } while (RunProgram);
            
        }
    }
}
